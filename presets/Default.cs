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

namespace ChromaVisualizer
{
    public class Default : AbstractPreset
    {
        public Default()
            : base(" + Default")
        {
            colors.Add(System.Drawing.Color.FromArgb(31, 229, 0));
            colors.Add(System.Drawing.Color.FromArgb(120, 234, 2));
            colors.Add(System.Drawing.Color.FromArgb(211, 239, 5));
            colors.Add(System.Drawing.Color.FromArgb(244, 185, 8));
            colors.Add(System.Drawing.Color.FromArgb(249, 102, 11));
            colors.Add(System.Drawing.Color.FromArgb(255, 6, 17));
        }

        public override Corale.Colore.Core.Color getBackgroundColor()
        {
            return getColoreColor(System.Drawing.Color.FromArgb(0, 0, 0));
        }

        public override Corale.Colore.Core.Color getColor(int row, int column, int maxRow)
        {
            switch (row)
            {
                case 5: return getColoreColor(colors[0]);
                case 4: return getColoreColor(colors[1]);
                case 3: return getColoreColor(colors[2]);
                case 2: return getColoreColor(colors[3]);
                case 1: return getColoreColor(colors[4]);
                case 0: return getColoreColor(colors[5]);
            }

            return getColoreColor(System.Drawing.Color.FromArgb(0, 0, 0));
        }
    }
}
