using System;
using System.Collections.Generic;
using System.Text;

namespace UF9
{
    class Alumno
    {
        string nombre {get; set; }
        int edad {get; set; }

        public Alumno(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public void Imprimir()
        {
            Console.WriteLine("{0} tiene {1} años", nombre, edad);
        }

        public void MayorDeEdad()
        {
            if (edad >= 18)
                Console.WriteLine("{0} es mayor de edad", nombre, edad);
            else
                Console.WriteLine("{0} no es mayor de edad", nombre, edad);
        }
    }
}
