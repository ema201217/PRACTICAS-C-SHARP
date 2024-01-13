using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVehiculos
{
    internal class Coche : Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Conduciendo COCHE");
        }

        public void Acelerar()
        {
            Console.WriteLine("Acelerando....");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenando....");
        }
    }
}
