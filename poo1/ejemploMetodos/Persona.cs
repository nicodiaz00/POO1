using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploMetodos
{
    internal class Persona
    {
        private string nombre;
        private int edad;
        private string apellido;

        public void setNombre(string name)
        {
            nombre = name;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setEdad(int age)
        {
            edad = age;
        }
        public int getEdad()
        {
            return edad;
        }
        public void setApellido(string lastName)
        {
            apellido = lastName;
        }
        public string getApellido()
        {
            return apellido;
        }

        //METODO

        public string saludar()
        {
            return "hola soy " + nombre;
        }
    }
}
