using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Programa
    {
        static void Main(string[] args)
        {
         const int inicio = 1852;
         const int fin = 2023;
            for (int i = inicio; i < fin; i = i + 4)
            {
                Console.WriteLine(i);
            }
    }
    }
}
