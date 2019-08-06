using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagartija69
{
    class Lagartija : Oviparos
    {
        public override void getNombre(string nombre)
        {
            //throw new NotImplementedException();
        }

        public void MostrarNombre(string nombre)
        {
            Console.WriteLine("Se llama " + nombre);
        }
        public void NumPatas()
        {
            Console.WriteLine("Tiene 4 patas");

        }
    }
}
