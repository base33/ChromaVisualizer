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
    public class Freaky : AbstractPreset
    {
        private Random e;

        public Freaky() 
            : base(" + Random Colors !!!")
        {
            e = new Random();
            colors.Add(System.Drawing.Color.FromArgb(0, 0, 0));
            colors.Add(System.Drawing.Color.FromArgb(0, 0, 0));

            colors.Add(System.Drawing.Color.FromArgb(0, 0, 0));
            colors.Add(System.Drawing.Color.FromArgb(0, 0, 0));

            colors.Add(System.Drawing.Color.FromArgb(0, 0, 0));
            colors.Add(System.Drawing.Color.FromArgb(0, 0, 0));
        }

        public override Corale.Colore.Core.Color getBackgroundColor()
        {
            return getColoreColor(System.Drawing.Color.FromArgb(0, 0, 0));
        }

        public override Corale.Colore.Core.Color getColor(int row, int column, int maxRow)
        {
            return getColoreColor(System.Drawing.Color.FromArgb(e.Next(0, 255), e.Next(0, 255), e.Next(0, 255)));
        }

    }
}
