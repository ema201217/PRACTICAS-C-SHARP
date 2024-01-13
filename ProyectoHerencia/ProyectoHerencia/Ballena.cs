using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia
{
    internal class Ballena:Mamifero
    {
        public Ballena(string nombreBallena) : base(nombreBallena) { }

        public void Nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }

    }
}
