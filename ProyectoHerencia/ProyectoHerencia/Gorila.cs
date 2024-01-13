using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia
{
    internal class Gorila : Mamifero, IMamiferosTerrestres
    {
        public Gorila(string nombreGorila) : base(nombreGorila){}

        public override void Pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }

        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public int NumeroPatas() => 2;
    }
}
