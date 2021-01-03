using System;
using System.Collections.Generic;
using System.Text;

namespace UF9
{
    class Person
    {
        private string nombre { get; set; }
        private int edad { get; set; }
        private string dni { get; set; }
        private string sexo { get; set; }
        private double peso { get; set; }
        private double altura { get; set; }

        private const string GENERO = "M";

        public Person()
        {
            this.nombre = "";
            this.edad = 0;
            this.dni = "123456789A";
            this.sexo = GENERO;
            this.peso = 0;
            this.altura = 0;
        }

        public Person(string nombre, int edad, string sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = GENERO;
        }

        public Person(string nombre, int edad, string dni, string sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.sexo = GENERO;
            this.peso = peso;
            this.altura = altura;
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre);
            Console.WriteLine(edad);
            Console.WriteLine(dni);
            Console.WriteLine(sexo);
            Console.WriteLine(peso);
            Console.WriteLine(altura);

        }
    }
}
