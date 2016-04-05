using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio19_2._0
{
    class Boligrafo
    {
        private ConsoleColor _color;
        private int _tinta;

        public Boligrafo(ConsoleColor Color, int Tinta)
        {
            this._color = Color;
            this._tinta = Tinta;
        }

        public ConsoleColor getColor()
        {
            return this._color;
        }

        public int getTinta()
        {
            return this._tinta;
        }

        public bool Pintar(int gasto)
        { }

        public void Recargar()
        { }
    }
}
