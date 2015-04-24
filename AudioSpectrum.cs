/*
Chroma Visualizer
Copyright (c) 2015 Kevin 'keving' Goeldenitz

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Threading;
using Un4seen.Bass;
using Un4seen.BassWasapi;

namespace ChromaVisualizer
{
    public class AudioSpectrum
    {
        private float[] _fft;               //buffer for fft data
        private WASAPIPROC _process;        //callback function to obtain data
        private int _lastlevel;             //last output level
        private int _hanctr;                //last output level counter
        private int devindex;               //used device index
        private bool initialized = false;
        private BASS_WASAPI_DEVICEINFO[] devices;

        // Threading
        private Thread _AnalysisThread;

        // Events
        public delegate void SpectrumData(List<float> spectrumData);
        public event SpectrumData OnSpectrumData;
        public delegate void VolumeData(int left, int right);
        public event VolumeData OnVolume;

        // Spectrum related
        private int _lines = 23;
        private List<float> _spectrumdata;


        public AudioSpectrum()
        {
            devices  = BassWasapi.BASS_WASAPI_GetDeviceInfos();

            _spectrumdata = new List<float>();
            _process = new WASAPIPROC(Process);

            _fft = new float[1024];

            Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_UPDATETHREADS, false);
            StartAnalysis();
        }

        ~AudioSpectrum()
        {
            this.StopAnalysis();
            BassWasapi.BASS_WASAPI_Stop(false);
            Free();
        }

        public BASS_WASAPI_DEVICEINFO[] getDeviceList()
        {
            return this.devices;
        }

        public void Dispose()
        {
            this.initialized = false;
            this.StopAnalysis();
            BassWasapi.BASS_WASAPI_Stop(false);
            Bass.BASS_Stop();
            Free();
        }

        public void setDevice(int deviceIndex)
        {
            this.Stop();
            this.devindex = deviceIndex;
            this.Start();
        }

        private void StartAnalysis()
        {
            if (_AnalysisThread != null && _AnalysisThread.IsAlive)
            {
                return;
            }

            _AnalysisThread = new Thread(delegate()
            {
                while (true)
                {
                    Thread.Sleep(25); // Refresh Rate
                    PerformAnalysis();
                }
            });

            _AnalysisThread.Priority = ThreadPriority.Highest;
            _AnalysisThread.Start();
        }

        private void StopAnalysis()
        {
            if (_AnalysisThread != null && _AnalysisThread.IsAlive)
            {
                _AnalysisThread.Abort();
            }
        }

        public void Start()
        {
            Bass.BASS_Init(0, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
            BassWasapi.BASS_WASAPI_Init(devindex, 0, 0, BASSWASAPIInit.BASS_WASAPI_BUFFER, 1f, 0.05f, _process, IntPtr.Zero);
            BassWasapi.BASS_WASAPI_Start();
            this.initialized = true;
        }

        public void Stop()
        {
            this.initialized = false;
            BassWasapi.BASS_WASAPI_Stop(true);
            Free();
        }

        private void PerformAnalysis()
        {
            int ret = BassWasapi.BASS_WASAPI_GetData(_fft, (int)BASSData.BASS_DATA_FFT2048); //get channel fft data
            if (ret < -1) return;

            if (!initialized)
                return;

            int x;
            int b0 = 0;

            int level = BassWasapi.BASS_WASAPI_GetLevel();
            float y;

            for (x = 0; x < _lines; x++)
            {
                float peak = 0;
                int b1 = (int)Math.Pow(2, x * 10.0 / (_lines - 1));
                if (b1 > 1023) b1 = 1023;
                if (b1 <= b0) b1 = b0 + 1;
                for (; b0 < b1; b0++)
                {
                    if (peak < _fft[1 + b0]) peak = _fft[1 + b0];
                }

                y = (float)(Math.Sqrt(peak) * 3 * 750 - 4);
                if (y < 0) y = 0;
                if (y > 360)
                {
                    y /= 3f;
                    if (y > 360)
                    {
                        y /= 1.2f;
                        y = 360;
                    }
                }

                _spectrumdata.Add(y );
            }

            if (OnVolume != null)
                OnVolume(Utils.LowWord32(level), Utils.HighWord32(level));

            if (OnSpectrumData != null)
                OnSpectrumData(_spectrumdata);

            _spectrumdata.Clear();

            y = 0;

            if (level == _lastlevel && level != 0) _hanctr++;
            _lastlevel = level;

            if (_hanctr > 3)
            {
                _hanctr = 0;
                this.Stop();
                this.Start();

                _lastlevel = 0;
                level = 0;
            }

            Array.Clear(_fft, 0, _fft.Length);
        }

        private int Process(IntPtr buffer, int length, IntPtr user)
        {
            return length;
        }

        private void Free()
        {
            BassWasapi.BASS_WASAPI_Free();
            Bass.BASS_Free();
        }
    }
}
