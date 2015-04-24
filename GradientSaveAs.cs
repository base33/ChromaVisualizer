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
using System.Windows.Forms;
using System.IO;

using Newtonsoft.Json;

namespace ChromaVisualizer
{
    public partial class GradientSaveAs : Form
    {
        private ChromaForm form;

        public GradientSaveAs(ChromaForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPresetName.Text == "")
            {
                MessageBox.Show("You need to enter a Filename for the preset ", "Preset name is missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            JsonStruct preset = form.getCustomGradient();
            preset.name = txtPresetName.Text;

            string file = txtPresetName.Text.ToLower() + ".json";
            string location = Helper.getAppLocation() + @"\presets\";

            FileInfo fi = new FileInfo(location + file);
            if (fi.Exists)
            {
                DialogResult result = MessageBox.Show("There is allready a preset with the name: " + file + "\n Would you like to overwrite it?", "File allready exists", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    save2File(fi, preset);
                }
            }
            else
            {
                save2File(fi, preset);
            }


            this.Close();
        }

        private void save2File(FileInfo file, JsonStruct preset)
        {
            string output = JsonConvert.SerializeObject(preset);
            using (StreamWriter writer = new StreamWriter(file.FullName, false))
            {
                writer.WriteLine(output);
                writer.Flush();
            }

            MessageBox.Show("You Preset has been saved as " + file.Name, "Preset saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
