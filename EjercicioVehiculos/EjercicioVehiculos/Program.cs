using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probando Avion");
            Avion miAvion = new Avion();

            miAvion.ArrancarMotor("tracatratractar");
            miAvion.Despegar();
            miAvion.Conducir();
            miAvion.Aterrizar();
            miAvion.PararMotor("ploooof");


            Console.WriteLine();
            Console.WriteLine("probando el coche");
            Coche miCoche = new Coche();
            miCoche.ArrancarMotor("grrrrum grrrrrummm");

            miCoche.Acelerar();
            miCoche.Conducir();
            miCoche.Frenar();
            miCoche.PararMotor("bluuuuuuuf");

            Console.WriteLine();
            Console.WriteLine("Polimorfismo en acción!");


            Vehiculo miVehiculo = miCoche;

            miVehiculo.Conducir();

            miVehiculo = miAvion;

            miVehiculo.Conducir();
        }
    }
}
