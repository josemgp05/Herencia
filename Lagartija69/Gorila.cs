using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagartija69
{
    class Gorila : Mamiferos
    {
      
        public void Trepar()
        {
            Console.WriteLine("Trepa arboles");
        }
        public void NumPatas()
        {
            Console.WriteLine("Tiene 2 patas");
        }

        public void MostrarNombre(string nombre)
        {
            Console.WriteLine("Se llama " + nombre);


        }
    }
}