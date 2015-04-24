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
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace ChromaVisualizer
{
    public class DynamicPeak : AbstractPreset
    {
        public DynamicPeak() 
            : base(" + Dynamic Peak")
        {
            colors.Add(System.Drawing.Color.FromArgb(0, 255, 0));
            colors.Add(System.Drawing.Color.FromArgb(0, 255, 0));

            colors.Add(System.Drawing.Color.FromArgb(255, 255, 0));
            colors.Add(System.Drawing.Color.FromArgb(255, 255, 0));

            colors.Add(System.Drawing.Color.FromArgb(255, 0, 0));
            colors.Add(System.Drawing.Color.FromArgb(255, 0, 0));
        }

        public override Corale.Colore.Core.Color getBackgroundColor()
        {
            return getColoreColor(System.Drawing.Color.FromArgb(0, 0, 0));
        }

        public override Corale.Colore.Core.Color getColor(int row, int column, int maxRow)
        {
            // Alle reihen
            if (maxRow == 6)
            {
                return getColoreColor(System.Drawing.Color.FromArgb(255, 0, 0));
            }
            if (maxRow <= 2)
            {
                return getColoreColor(System.Drawing.Color.FromArgb(255, 255, 0));
            }

            if ((maxRow > 2 && maxRow <= 4) || (maxRow < 6 && maxRow >= 4))
            {
                return getColoreColor(System.Drawing.Color.FromArgb(0, 255, 0));
            }

            return getColoreColor(System.Drawing.Color.FromArgb(0, 0, 0));
        }
    }
}
