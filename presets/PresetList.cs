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
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace ChromaVisualizer
{
    public class JsonStruct
    {
        public string name { get; set; }

        public IList<int[]> colors { get; set; }
        public int[] bgColor { get; set; }
    }

    public class PresetList
    {

        private Hashtable presets = new Hashtable();

        private void LoadPresetsFromHdd()
        {

            DirectoryInfo dirInfo = new DirectoryInfo(Helper.getAppLocation() + "\\presets");
            if (dirInfo.Exists)
            {
                foreach (FileInfo f in dirInfo.GetFiles())
                {
                    using (StreamReader r = new StreamReader(f.FullName))
                    {
                        try
                        {
                            CPreset p = new CPreset();

                            string json = r.ReadToEnd();
                            JsonStruct obj = JsonConvert.DeserializeObject<JsonStruct>(json);

                            p.setName(obj.name);
                            p.setBGColor(System.Drawing.Color.FromArgb(obj.bgColor[0], obj.bgColor[1], obj.bgColor[2]));


                            foreach (int[] color in obj.colors)
                            {
                                p.addColor(System.Drawing.Color.FromArgb(color[0], color[1], color[2]));
                            }

                            this.addPreset(p);
                        }
                        catch (Exception ex)
                        {
                            Helper.logError(ex);
                            MessageBox.Show(ex.ToString(), "Error loading preset. " + f.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }
                    }
                }
            }
            else
            {
                dirInfo.Create();
            }

            dirInfo = null;
        }

        public PresetList()
        {

        }

        public void loadPresets()
        {
            addPreset(new Default());
            addPreset(new Freaky());
            addPreset(new DynamicPeak());

            this.LoadPresetsFromHdd();

            //addPreset(new PeakMeter());
            //addPreset(new ColdIcy());
        }

        ~PresetList()
        {
            presets.Clear();
            presets = null;
        }

        public List<AbstractPreset> getPresets()
        {
            List<AbstractPreset> tmp = new List<AbstractPreset>();

            foreach (DictionaryEntry entry in presets)
            {
                tmp.Add((AbstractPreset)entry.Value);
            }

            return tmp;
        }

        private void addPreset(AbstractPreset p)
        {
            this.presets.Add(p.getName(), p);
        }

        public AbstractPreset getPreset(string name)
        {
            return (AbstractPreset) this.presets[name];
        }
    }
}
