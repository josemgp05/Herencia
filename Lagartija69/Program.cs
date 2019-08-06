using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagartija69
{

    public abstract class Program
    {


        static void Main(string[] args)
        {
            Humano Humano1 = new Humano();
            Humano1.getNombre("Ale");
            Humano1.MostrarNombre("Francia");
            Humano1.Respirar();
            Humano1.Pensar();
            Humano1.CuidarCrias();
            Humano1.Razonar();
            Humano1.NumPatas();
            Console.WriteLine("-------------------------");
            Ballena Ballena1 = new Ballena();
            Ballena1.getNombre("Willie");
            Ballena1.MostrarNombre("Willie");
            Ballena1.Respirar();
            Ballena1.Pensar();
            Ballena1.CuidarCrias();
            Ballena1.Nadar();
            Console.WriteLine("-------------------------");
            Perro Perro1 = new Perro();
            Perro1.getNombre("Firulais");
            Perro1.MostrarNombre("Firulais");
            Perro1.Respirar();
            Perro1.Pensar();
            Perro1.CuidarCrias();
            Perro1.Correr();
            Perro1.NumPatas();
            Console.WriteLine("-------------------------");

            Gorila Gorila1 = new Gorila();
            Gorila1.getNombre("Gorila3");
            Gorila1.MostrarNombre("Gorila3");
            Gorila1.Respirar();
            Gorila1.Pensar();
            Gorila1.CuidarCrias();
            Gorila1.Trepar();
            Gorila1.NumPatas();
            Console.WriteLine("-------------------------");

            Lagartija Lagartija1 = new Lagartija();
            Lagartija1.getNombre("Rango");
            Lagartija1.MostrarNombre("Rango");
            Lagartija1.Respirar();
            Lagartija1.CuidarCrias();

            Lagartija1.NumPatas();
            Console.ReadKey();
        }
    }
}
