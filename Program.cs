using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio19_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo TintaAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo TintaRoja = new Boligrafo(ConsoleColor.Red, 50);

            Console.Write("Boligrafo Azul: ");
            TintaAzul.Pintar(150);
            TintaAzul.Recargar();

            Console.Write("\n\nBoligrafo Rojo: ");
            TintaRoja.Pintar(25);
            TintaRoja.Recargar();

            Console.ReadKey();
        }
    }
}
