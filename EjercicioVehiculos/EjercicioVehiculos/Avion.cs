using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVehiculos
{
    internal class Avion : Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Conduciendo AVION");
        }

        public void Despegar()
        {
            Console.WriteLine("Despegando...");
        }

        public void Aterrizar()
        {
            Console.WriteLine("Aterrizando...");
        }
    }
}
