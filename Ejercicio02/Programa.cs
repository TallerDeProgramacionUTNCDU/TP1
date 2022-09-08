using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Programa //LISTO
    {
        static void Main(string[] args)
        {
            //Utilizando FOR: 

            Console.WriteLine("Ingrese el primer numero");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int j = int.Parse(Console.ReadLine());
            int cantidadNumeros = 0;
            int sumatoria = 0;
            for (int i = numero1; i != j+1; i++)
            {
                sumatoria = sumatoria + i;
                cantidadNumeros = cantidadNumeros + 1;
            }
            Console.Clear();
            Console.WriteLine("Realizado con FOR");
            Console.WriteLine("El valor minimo ingresado fue: " + numero1);
            Console.WriteLine("El valor maximo ingresado fue: " + j);
            Console.WriteLine("La sumatoria de los elementos entre "+numero1+" y "+j+" es de: "+sumatoria);
            Console.WriteLine("El promedio es de: "+sumatoria / cantidadNumeros);
            Console.ReadLine();

            //Utilizando WHILE:
            int inicio = numero1;
            cantidadNumeros = 0;
            sumatoria = 0;
            while ( inicio != j + 1)
            {
                sumatoria = sumatoria + inicio;
                cantidadNumeros = cantidadNumeros + 1;
                inicio++;
            }
            Console.Clear();
            Console.WriteLine("Realizado con WHILE");
            Console.WriteLine("El valor minimo ingresado fue: " + numero1);
            Console.WriteLine("El valor maximo ingresado fue: " + j);
            Console.WriteLine("La sumatoria de los elementos entre " + numero1 + " y " + j + " es de: " + sumatoria);
            Console.WriteLine("El promedio es de: " + sumatoria / cantidadNumeros);
        }
    }
}
