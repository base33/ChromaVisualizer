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
using System.Reflection;
using System.Windows.Forms;

namespace ChromaVisualizer
{
    public class Helper
    {
        public static string getAppLocation()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

        public static void setColorsOnPB(List<System.Drawing.Color> colors, PictureBox[] boxes)
        {
            for (int i=0; i < boxes.Length; i++)
            {
                PictureBox box = boxes[i];
                if (!box.InvokeRequired)
                {
                    box.BackColor = colors[i];
                }
                else
                {
                    box.Invoke((MethodInvoker)delegate { box.BackColor = colors[i]; });
                }
            }

            colors = null;
        }

        public static void logError(Exception e)
        {
            var stackTrace = Environment.StackTrace;
            using (StreamWriter writer = new StreamWriter(Helper.getAppLocation() + "\\error.log", true))
            {
                writer.WriteLine("-----------------------------------------------------------------------------------------");
                writer.WriteLine(e.ToString());
                writer.WriteLine(stackTrace);
                writer.WriteLine("-----------------------------------------------------------------------------------------");
                writer.Flush();
            }

        }

        public static System.Drawing.Color newColor(int R, int G, int B)
        {
            return System.Drawing.Color.FromArgb(R,G,B);
        }

        public static System.Drawing.Color Colore2Drawing(Corale.Colore.Core.Color c)
        {
            return System.Drawing.Color.FromArgb(c.R, c.G, c.B);
        }

        public static Corale.Colore.Core.Color Drawing2Colore(System.Drawing.Color c)
        {
            return new Corale.Colore.Core.Color(c.R, c.G, c.B);
        }
    }
}
