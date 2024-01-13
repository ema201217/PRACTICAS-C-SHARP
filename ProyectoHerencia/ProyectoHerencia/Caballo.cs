using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia
{
    internal class Caballo : Mamifero, IMamiferosTerrestres
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo) { }

        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        public int NumeroPatas()
        {
            return 4;
        }
    }
}
