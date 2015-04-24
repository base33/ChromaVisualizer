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
using System.IO;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace ChromaVisualizer
{
    public class Settings
    {
        public int sensity { get; set; }
        public int colorMode { get; set; }

        public IList<int[]> gradient { get; set; }
        public int[] gBGColor { get; set; }
    }

    public class Config
    {
        private static string configFile = "settings.json";

        private static Settings getDefaultConfig()
        {
            Settings cfg = new Settings();
            cfg.colorMode = 0;
            cfg.sensity = 1;
            cfg.gBGColor = new int[3] { 0, 0, 0 };

            cfg.gradient = new int[6][];

            cfg.gradient[0] = new int[3] { 31, 229, 0 };
            cfg.gradient[1] = new int[3] { 120, 234, 2 };

            cfg.gradient[2] = new int[3] { 211, 239, 5 };
            cfg.gradient[3] = new int[3] { 244, 185, 8 };

            cfg.gradient[4] = new int[3] { 249, 102, 11 };
            cfg.gradient[5] = new int[3] { 255, 6, 17 };

            return cfg;
        }

        public static Settings loadConfig()
        {
            Settings cfg = null;
            try
            {

                using (StreamReader r = new StreamReader(Helper.getAppLocation() + "\\" + configFile))
                {
                    string json = r.ReadToEnd();
                    cfg = JsonConvert.DeserializeObject<Settings>(json);

                    if (cfg.sensity == -1 && cfg.colorMode == -1)
                    {
                        MessageBox.Show("Error loading ConfigFile. Restoring default config...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cfg = getDefaultConfig();
                    }
                }
            }
            catch (Exception e)
            {
                Helper.logError(e);
                MessageBox.Show("Error loading ConfigFile. Restoring default config...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cfg = getDefaultConfig();
            }

            return cfg;
        }

        public static void writeConfig(int sensity, int colorMode, IList<int[]> gradient, int[] gradientBGColor)
        {
            Settings cfg = new Settings();
            cfg.sensity = sensity;
            cfg.colorMode = colorMode;
            cfg.gradient = gradient;
            cfg.gBGColor = gradientBGColor;

            string output = JsonConvert.SerializeObject(cfg);
            using (StreamWriter writer = new StreamWriter(Helper.getAppLocation() + "\\" + configFile, false))
            {
                writer.WriteLine(output);
                writer.Flush();
            }


            cfg = null;
            output = null;
        }
    }
}
