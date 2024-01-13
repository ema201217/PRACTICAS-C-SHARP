using System;

namespace switch_practica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Elige medio de transporte (coche, tren, avión");
            //string medioTrasnporte = Console.ReadLine();
            //switch (medioTrasnporte)
            //{
            //    case "coche":
            //        Console.WriteLine("Velocidad media: 100 km/h");
            //        break;
            //    case "tren":
            //        Console.WriteLine("Velocidad media: 250 km/h");
            //        break;
            //    case "aviòn":
            //        Console.WriteLine("Velovidad media: 800 km/h");
            //        break;
            //    default:
            //        Console.WriteLine("Transporte no contemplado");
            //        break;
            //}

            Console.WriteLine("Introduce nº de mes para càlculo de la comisiòn");
            int nMes = Int32.Parse(Console.ReadLine());
            switch (nMes)
            {
                case 1:
                    Console.WriteLine("Mes escogido: Enero");
                    break;
                case 2:
                    Console.WriteLine("Mes escogido: Febrero");
                    break;
                case 3:
                    Console.WriteLine("Mes escogido: Marzo");
                    break;
                case 4:
                    Console.WriteLine("Mes escogido: Abril");
                    break;
                case 5:
                    Console.WriteLine("Mes escogido: Mayo");
                    break;
                case 6:
                    Console.WriteLine("Mes escogido: Junio");
                    break;
                case 7:
                    Console.WriteLine("Mes escogido: Julio");
                    break;
                case 8:
                    Console.WriteLine("Mes escogido: Agosto");
                    break;
                case 9:
                    Console.WriteLine("Mes escogido: Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Mes escogido: Octubre");
                    break;
                case 11:
                    Console.WriteLine("Mes escogido: Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Mes escogido: Diciembre");
                    break;
                default:
                    Console.WriteLine("Mes incorrecto");
                    break;
            }
            Console.WriteLine("Ha terminado el programa");
        }
    }
}
