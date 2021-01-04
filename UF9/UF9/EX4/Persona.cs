using System;
using System.Collections.Generic;
using System.Text;

namespace UF9
{
    class Persona
    {
        private string nombre { get; set; }

        public Persona()
        {
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetNombre(string n)
        {
            this.nombre = n;
        }
        public void Saludar()
        {
            Console.WriteLine("Hola soy " + this.nombre) ;
        }

    }
}
