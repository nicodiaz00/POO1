using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploDosMetodos
{
    internal class Botella
    {
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;


        }
        private string color;
        private string material;
        private float capacidad;
        private float cantidadActual;

        public string Color
        {
            get { return color; }
        }
        public string Material
        {
            get { return material; }
        }

        public float Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

        public float CantidadActual
        {
            get { return cantidadActual; }
            set { cantidadActual = value; }
        }

        public float recargar()
        {
            int costo = 50;
            if(cantidadActual == 0)
            {
                cantidadActual = 100;
                return costo;
            }
            else
            {
                float costoFinal = calculcarCosto(cantidadActual, costo);
                return costoFinal;
            }
            

        }

        float calculcarCosto(float valorcantidad, int valorDiferencia)
        {
            float costoTotal = (valorcantidad * valorDiferencia) / 100;
            return costoTotal;
        }
    }
}
