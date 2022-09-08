using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace Ejercicio_08
{ 
    class Program
    {
        static long Factorial(long val)
        {
            long res = 1;
            for (int index = 1; index <= val; index++)
            {
                res = res*index;
            }
            return res;
        }
            static void Main(string[] args)
        {
            Console.Write("Ingrese la dimensión del Triángulo de Pascal: ");
            var nro = Console.ReadLine();
            long dim = Int32.Parse(nro);
            for (int n = 0; n <= dim; n++)
            {
                for (int k = 1; k <= n; k++)
                { 
                    long nfact = Factorial(n);
                    long kfact = Factorial(k);
                    long nkfact = Factorial(n - k);
                    long res = nfact / (kfact * nkfact);
                    Console.Write(" "+ res);
                }
            Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}