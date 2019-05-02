using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3Parcial.Clases;

namespace _3Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro p = new Perro();
            Gato g = new Gato();
            string s;
            s = p.Talk();
            s = g.Talk();
        }
    }
}
