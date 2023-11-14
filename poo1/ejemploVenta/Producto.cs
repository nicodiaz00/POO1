using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploVenta
{
    internal class Producto
    {
        private int codArticulo;
        private float precio;
        private int codMarca;

        public void setCodArticulo( int codigo)
        {
            codArticulo = codigo;
        }
        public int getCodArticulo()
        {
            return codArticulo;
        }
        public void setPrecio(float valor)
        {
            precio = valor;
        }
        public float getPrecio()
        {
            return precio;
        }
        public void setCodMarca(int codigoMarca)
        {
            int codigoError = -1;
            if(codigoMarca >0 && codigoMarca < 11)
            {
                codMarca = codigoMarca;
            }
            else
            {
                codMarca = codigoError;
            }
            
        }
        public int getCodMarca()
        {
            return codMarca;
        }
    }
}
