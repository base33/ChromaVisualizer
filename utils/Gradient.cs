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

using System.Collections.Generic;

namespace ChromaVisualizer
{
    public class Gradient
    {
        public static List<System.Drawing.Color> createGradient(System.Drawing.Color origin, System.Drawing.Color target, int steps = 6)
        {
            int redStep     = (target.R - origin.R) / (steps - 1);
            int greenStep   = (target.G - origin.G) / (steps - 1);
            int blueStep    = (target.B - origin.B) / (steps - 1);

            List<System.Drawing.Color> tmp = new List<System.Drawing.Color>();
            for (int i = 0; i < steps; i++)
            {
                tmp.Add(System.Drawing.Color.FromArgb(origin.R + (redStep * i), origin.G + (greenStep * i), origin.B + (blueStep * i)));
            }

            redStep = 0;
            greenStep = 0;
            blueStep = 0;

            return tmp;
        }
    }
}
