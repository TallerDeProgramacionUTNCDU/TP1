using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cuantos numeros de la suceción desea ver");
            int numero = int.Parse(Console.ReadLine());
            double X = 0;
            double Y = 1;
            if (numero > 0)
            {
                for (int i = 1; i <= numero; i++)
                {
                    double aux = X;
                    X = Y;
                    Y = aux + X;
                    Console.WriteLine("El numero " + i + " de la suceción de fibonacci es: " + X);
                }
            }
            Console.ReadKey();
        }
    }
}
