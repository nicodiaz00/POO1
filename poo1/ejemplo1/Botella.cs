using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        private int capacidad;
        private string color;
        private string material;

        public void setCapacidad(int cap)
        {
            capacidad = cap;
        }

        public   int getCapacidad()
        {
            return capacidad;
        }
    }
}
