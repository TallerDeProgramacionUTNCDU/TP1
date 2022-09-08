using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero N");
            int n = int.Parse(Console.ReadLine());
            double numerador = 0;
            double denominador= 0;
            double resultado = 0;
            double fraccion = 0;
            for (int i = 0; i != n; i++)
            {
                numerador = Math.Pow(-1, i);            //-1^n
                denominador = 2 * i + 1;                //2n+1
                fraccion = numerador / denominador;     //1/1, -1/3, 1/5 
                resultado = resultado + fraccion;
            }
            double pi = resultado * 4;
            Console.WriteLine("El resultado es: "+ pi);
            Console.WriteLine(Math.PI);
            Console.WriteLine((pi/Math.PI)*100+"%");

        }
    }

}
