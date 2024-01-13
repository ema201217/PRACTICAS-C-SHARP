using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo miCaballo = new Caballo("Babieca");
            Humano miHumano = new Humano("Emanuel");
            Gorila miGorila = new Gorila("Copito");

            Mamifero[] almacenAnimales = new Mamifero[3];

            almacenAnimales[0] = miCaballo;
            almacenAnimales[1] = miHumano;
            almacenAnimales[2] = miGorila;

            foreach(Mamifero m in almacenAnimales)
            {
                m.Pensar();
            }

            Mamifero miMamifero = new Mamifero("");
            miMamifero.Respirar();

            Ballena miBallena = new Ballena("Wally");
            miBallena.Nadar();

            Console.WriteLine($"Numero de patas del caballo {miCaballo.NumeroPatas()}");
        }
    }
}
