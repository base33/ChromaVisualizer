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
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Principal;

using Corale.Colore.Core;
using Un4seen.Bass;

namespace ChromaVisualizer
{
    public partial class ChromaForm : Form
    {
        private AudioSpectrum _as;
        private PresetList pl;

        private int devindex;
        private string curTab = "Presets";
        private Random r = new Random();

        private AbstractPreset curPreset;

        private int _colorMode = 0;
        private int _sensity = 3;

        private PictureBox[] pbsGradient;
        private PictureBox[] pbsPreset;

        public ChromaForm()
        {
            BassNet.Registration("hacker@fbi.gov", "2X3133714161117");

            InitializeComponent();

            pbsGradient = new PictureBox[6] { cGradient1, cGradient2, cGradient3, cGradient4, cGradient5, cGradient6 };
            pbsPreset = new PictureBox[6] { pGradient1, pGradient2, pGradient3, pGradient4, pGradient5, pGradient6 };

            pl = new PresetList();

            _as = new AudioSpectrum();
            _as.OnSpectrumData += OnSpectrumData;
            _as.OnVolume += OnVolume;
        }

        private int MaxRows = 6;

        private Corale.Colore.Core.Color getRazerColor(System.Drawing.Color g)
        {
            return new Corale.Colore.Core.Color(g.R, g.G, g.B);
        }

        private Corale.Colore.Core.Color getBackgroundColor()
        {
            if (curTab == "Presets")
            {
                return curPreset.getBackgroundColor();
            }
            else if (curTab == "Custom Gradient")
            {
                return this.getRazerColor(cGradient7.BackColor);
            }


            return Color.Black;
        }

        /// <summary>
        /// Returns a Color for the key @ row + column
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Corale.Colore.Core.Color getKeyColor(int row, int column, int maxRow)
        {
            if (_colorMode == 0)
            {
                return curPreset.getColor(row, column, maxRow);
            }
            else if (_colorMode == 1)
            {
                switch (row)
                {
                    case 5: return this.getRazerColor(cGradient1.BackColor);
                    case 4: return this.getRazerColor(cGradient2.BackColor);
                    case 3: return this.getRazerColor(cGradient3.BackColor);
                    case 2: return this.getRazerColor(cGradient4.BackColor);
                    case 1: return this.getRazerColor(cGradient5.BackColor);
                    case 0: return this.getRazerColor(cGradient6.BackColor);
                }
            }


            return Color.Black;
        }

        private void do_StartStop_Click(object sender, EventArgs e)
        {
            if (do_StartStop.Text == "Start")
            {
                do_StartStop.Text = "Stop";
                deviceList.Enabled = false;

                var array = (deviceList.Items[deviceList.SelectedIndex] as string).Split(' ');
                devindex = Convert.ToInt32(array[0]);

                _as.setDevice(devindex);
                _as.Start();
            }else if (do_StartStop.Text == "Stop")
            {
                do_StartStop.Text = "Start";
                _as.Stop();
                progressBar1.Value = 0;
                progressBar2.Value = 0;


                deviceList.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
            {
                MessageBox.Show("This Program does not require admin privileges and will stop now.", "Warning: Don't run as admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            if (!SDKSupport.isSDKInstalled())
            {
                MessageBox.Show("Please make sure you have the Razer Chroma SDK installed and \nmake you sure executed the Enable SDK.reg file.  \nThis Program do not work without the SDK.", "Error: Missing Razer Chroma SDK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            Process[] pname = Process.GetProcessesByName("RzSynapse");
            if (pname.Length != 0)
            {
                MessageBox.Show("Please close Razer Synapse before running this Program.", "Error: Razer Synpase is running", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            do_StartStop.Text = "Start";
            deviceList.Enabled = true;


            // Device List
            for (int i = 0; i < _as.getDeviceList().Length; i++)
            {
                var device = _as.getDeviceList()[i];
                if (device.IsEnabled && device.IsLoopback)
                {
                    deviceList.Items.Add(string.Format("{0} - {1}", i, device.name));
                }
            }
            deviceList.SelectedIndex = 0;

            // Preset List
            pl.loadPresets();
            foreach (AbstractPreset preset in pl.getPresets())
            {
                presetList.Items.Add(preset.getName());
            }
            presetList.Text = " + Default";
            curPreset = pl.getPreset(" + Default");


            // Load Gradient colors
            List<System.Drawing.Color> colors = pl.getPreset(" + Default").getColors();
            Helper.setColorsOnPB(colors, pbsGradient);


            Settings config = Config.loadConfig();
            colorMode.SelectedIndex = config.colorMode;
            spectrumSensitivity.SelectedIndex = config.sensity;
            List<System.Drawing.Color> p = new List<System.Drawing.Color>();
            for (int x = 0; x < pbsGradient.Length; x++)
            {
                p.Add(Helper.newColor(config.gradient[x][0], config.gradient[x][1], config.gradient[x][2]));
            }

            Helper.setColorsOnPB(p, pbsGradient);

            cGradient7.BackColor = Helper.newColor(config.gBGColor[0], config.gBGColor[1], config.gBGColor[2]);

            p = null;
            config = null;
            colors = null;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<int[]> gradient = new List<int[]>();

            foreach (PictureBox c in pbsGradient)
            {
                gradient.Add(new int[3] { c.BackColor.R, c.BackColor.G, c.BackColor.B });
            }
            Config.writeConfig(spectrumSensitivity.SelectedIndex, colorMode.SelectedIndex, gradient, new int[3] { cGradient7.BackColor.R, cGradient7.BackColor.G, cGradient7.BackColor.B });


            _as.Stop();
            _as.Dispose();

            gradient = null;
            _as = null;
        }

        private void btn_createGradient_Click(object sender, EventArgs e)
        {
            List<System.Drawing.Color> gradient = Gradient.createGradient(cGradient1.BackColor, cGradient6.BackColor, 6);

            Helper.setColorsOnPB(gradient, pbsGradient);
            gradient = null;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl src = (TabControl)sender;
            curTab = src.SelectedTab.Text;
        }

        private void colorDialog_click(object sender, EventArgs e)
        {
            PictureBox origin = (PictureBox)sender;
            colorDialog1.Color = origin.BackColor;

            lock (sender)
            {
                DialogResult result = colorDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    origin.BackColor = colorDialog1.Color;
                }
            }
        }

        #region Event Handlers
        private void OnVolume(int left, int right)
        {
            if (left > progressBar1.Maximum || right > progressBar2.Maximum)
                return;

            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    progressBar1.Value = left;
                    progressBar2.Value = right;
                });
            }
        }

        private void OnSpectrumData(List<float> spectrumData)
        {
            Color[][] grid = Enumerable.Range(0, 6).Select(i => new Color[22]).ToArray();

            for (int column = 0; column < 22; column++)
            {
                for (int row = 0; row < 6; row++)
                {
                    grid[row][column] = getBackgroundColor();
                }
            }

            for (int column = 0; column < 23; column++)
            {
                float data = spectrumData[column];
                try
                {
                    int b = (int)(data / this._sensity);
                    if (b == 0)
                    {
                        continue;
                    }

                    if (b > 6) b = 6;
                    if (b == 1) b = 0;

                    if (b == 6)
                    {
                        for (int row = 0; row <= 6; row++)
                        {
                            grid[row][column] = getKeyColor(row, column, 6);
                        }
                        continue;
                    }

                    for (int row = (MaxRows - 1); row > (MaxRows - b); row--)
                    {
                        grid[row][column] = getKeyColor(row, column, (MaxRows - b));
                    }
                }

                catch (Exception e)
                {

                }
            }

            Keyboard.Instance.Set(grid);
        }
        #endregion

        private void spectrumSensitivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (spectrumSensitivity.SelectedIndex)
            {
                case 0: this._sensity = 50; break; // High Sensity
                case 1: this._sensity = 60; break; // Default
                case 2: this._sensity = 70; break; // Low Sensity
                default: return;
            }
        }

        private void colorMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox origin = (ComboBox)sender;
            this._colorMode = origin.SelectedIndex;
        }

        private void presetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox src = (ComboBox)sender;

            List<System.Drawing.Color> colors = pl.getPreset((presetList.Items[presetList.SelectedIndex] as string)).getColors();
            curPreset = pl.getPreset((presetList.Items[presetList.SelectedIndex] as string));

            Helper.setColorsOnPB(colors, pbsPreset);

        }

        private void btnGradientSave_Click(object sender, EventArgs e)
        {
            GradientSaveAs gsa = new GradientSaveAs(this);
            gsa.ShowDialog();
        }

        public JsonStruct getCustomGradient()
        {
            JsonStruct p = new JsonStruct();
            p.bgColor = new int[3] { cGradient7.BackColor.R, cGradient7.BackColor.G, cGradient7.BackColor.B };
            p.colors = new int[6][];

            for (int i = 0; i < pbsGradient.Length; i++)
            {
                p.colors[i] = new int[3] { pbsGradient[i].BackColor.R, pbsGradient[i].BackColor.G, pbsGradient[i].BackColor.B };
            }

            return p;
        }
    }
}
