using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVehiculos
{
    internal class Vehiculo
    {
        public void ArrancarMotor(string sonidoAlArrancar)
        {
            Console.WriteLine($"Motor arrancando {sonidoAlArrancar}");
        }

        public void PararMotor(string sonidoAlParar)
        {
            Console.WriteLine($"Parando motor {sonidoAlParar}");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("Conduciendo VEHICULO ");
        }
    }
}
