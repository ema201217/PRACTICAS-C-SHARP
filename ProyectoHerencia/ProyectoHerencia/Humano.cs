using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia
{
    internal class Humano :Mamifero
    {
        public Humano(string nombreHumano):base(nombreHumano) { }

        public override void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");
        }
    }
}
