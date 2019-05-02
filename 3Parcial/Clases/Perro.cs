using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Parcial.Clases
{
    class Perro: AnimalData, Interface
    {
        public string Talk()
        {
            return "guau";
        }
    }
}
