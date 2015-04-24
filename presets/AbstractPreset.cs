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
    public abstract class AbstractPreset
    {
        protected string name;
        protected List<System.Drawing.Color> colors;

        public AbstractPreset(string name)
        {
            this.colors = new List<System.Drawing.Color>();
            this.name = name;
        }

        public void addColor(System.Drawing.Color c)
        {
            colors.Add(c);
        }

        public string getName()
        {
            return this.name;
        }

        public List<System.Drawing.Color> getColors()
        {
            return colors;
        }

        public abstract Corale.Colore.Core.Color getColor(int row, int column, int maxRow);
        public abstract Corale.Colore.Core.Color getBackgroundColor();

        protected Corale.Colore.Core.Color getColoreColor(System.Drawing.Color g)
        {
            return new Corale.Colore.Core.Color(g.R, g.G, g.B);
        }

    }
}
