using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploConstructor
{
    internal class Botella
    {
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
        }
        private string color;
        private string material;
        private int capacidad;


        public void setCapacidad( int cap)
        {
            capacidad = cap;
        }
        public int getCapacidad()
        {
            return capacidad;
        }

        public void setColor(string valorColor)
        {
            color = valorColor;
        }
        public string getColor()
        {
            return color;
        }
        public void setMaterial(string valorMaterial)
        {
            material = valorMaterial;
        }
        public string getMaterial()
        {
            return material;
        }
    }
}
