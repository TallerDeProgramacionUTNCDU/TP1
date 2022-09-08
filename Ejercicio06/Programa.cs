using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor del radio del circulo");
            double radio = int.Parse(Console.ReadLine());
            double perimetro = 2*Math.PI*radio;
            double area = Math.PI * Math.Pow(radio,2);
            Console.WriteLine("Perimetro de la circunferencia: " + perimetro);
            Console.WriteLine("Perimetro de la circunferencia: " + area);
        }
    }
}
