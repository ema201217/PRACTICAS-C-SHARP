using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static double sumar (double n1, double n2) => n1 + n2;
        static double resta (double n1, double n2) => n1 - n2;
        static double multiplicacion (double n1, double n2) => n1 * n2;
        static double division (double n1, double n2)
        {
            if(n1 == 0 || n2 == 0) throw new Exception("Error: No puedes colocar el valor cero"); 
            return n1 / n2;
        }



        static void Main(string[] args)
        {
            double n1;
            double n2;

            Console.WriteLine("Ingresa la operación");
            string operation = Console.ReadLine();

            Console.WriteLine("Ingresa el primer número");
            bool n1IsNumber = double.TryParse(Console.ReadLine(), out n1);

            Console.WriteLine("Ingresa el segundo número");
            bool n2IsNumber = double.TryParse(Console.ReadLine(), out n2);

            double response = 0;

            try
            {

            if (!n1IsNumber || !n2IsNumber) throw new Exception("El valor ingresado no es un número");
            switch (operation)
            {
                case "sumar":
                    response = sumar(n1, n2);
                    break;
                case "resta":
                    response = resta(n1, n2);
                    break;
                case "multiplicacion":
                    response = multiplicacion(n1, n2);
                    break;
                case "division":
                    response = division(n1, n2);
                    break;
                default:
                    throw new Exception("La operación ingresada no existe");
            }
            Console.WriteLine(response);
            } catch (Exception e)
            {
                Console.WriteLine (e.Message);
            }
      
            
        }


    }
}
