using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Programa
    {
    
        static void Main(string[] args)
        {
            //Console.Write("Ingrese la primer palabra: ");
            //string palabra1 = Console.ReadLine();
            //Console.Write("Ingrese la segunda palabra: ");
            //string palabra2 = Console.ReadLine();
            //if (InvertirCadena(palabra1) == palabra2)
            //{
            //    Console.WriteLine(palabra1 + " y " + palabra2 + " son anagramas");

            //}
            //else
            //{
            //    Console.WriteLine(palabra1 + " y " + palabra2 + " NO son anagramas");
            //}

            //UTILIZANDO EL STRING ARGS

            string palabra1;
            string palabra2;
            palabra1 = args[0];
            palabra2 = args[1];
            if (InvertirCadena(palabra1) == palabra2)
            {
                Console.WriteLine(palabra1 + " y " + palabra2 + " son anagramas");

            }
            else
            {
                Console.WriteLine(palabra1 + " y " + palabra2 + " NO son anagramas");
            }


        }
        public static string InvertirCadena(string cadena)
        {
            char[] cadenaArray = cadena.ToCharArray();
            Array.Reverse(cadenaArray);
            return new string(cadenaArray);
        }

    }
}
