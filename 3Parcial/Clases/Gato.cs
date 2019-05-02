using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Parcial.Clases
{
    class Gato: AnimalData, Interface
    {
        public string Talk()
        {
            sound.Sonido();
            return "miau";
        }
    }
}
