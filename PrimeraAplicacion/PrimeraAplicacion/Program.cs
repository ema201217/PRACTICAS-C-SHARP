using System;

namespace PrimeraAplicacion
{
    class Program  // clase propia
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;

            Console.WriteLine("Introduce la medida del radio");

            double radio = double.Parse(Console.ReadLine());

            double area = radio * radio * PI;

            Console.WriteLine($"El area del circulo es: {area}");


        }
    }
} 