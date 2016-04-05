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
        {
            bool pintando;

            if (this._tinta >= gasto)
            {
                Console.Write("Pintando...");
                this._tinta = this._tinta - gasto;
                pintando = true;
            }
            else
            {
                Console.Write("No hay suficiente tinta");
                this._tinta = this._tinta - gasto;
                pintando = false;
            }

            return pintando;
        }

        public void Recargar()
        {
            if (this._tinta <= 0)
            {
                Console.Write("\nRecargando...");
                this._tinta = 100;
                Console.Write("\nCartucho cargado");
            }
            else
            {
                Console.Write("\nTodavía hay tinta");
            }
        }
    }
}
