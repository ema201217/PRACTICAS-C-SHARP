using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia
{
    internal class Mamifero
    {
        public Mamifero(string nombre) {
            this.nombreSerVivo = nombre;
        }

        public virtual void Pensar()
        {
            Console.WriteLine("Pensamiento básico instintivo");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que se valgan por si solas");
        }

        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void GetNombre()
        {
            Console.WriteLine(nombreSerVivo);
        }

        

        private string nombreSerVivo;
    }
}
