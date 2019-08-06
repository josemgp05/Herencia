using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagartija69
{
    class Perro : Mamiferos
    {
        public void Correr()
        {
            Console.WriteLine("Corre");
        }
        public void NumPatas()
        {
            Console.WriteLine("Tiene 4 patas");
        }

        public void MostrarNombre(string nombre)
        {
            Console.WriteLine("Se llama " + nombre);


        }
    }
}
