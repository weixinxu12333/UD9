using System;
using System.Collections.Generic;
using System.Text;

namespace UF9
{
    class Coche
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public int cilindrada { get; set; }
        public double potencia { get; set; }

        public Coche(string marca, string modelo, int cilindrada, double potencia)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cilindrada = cilindrada;
            this.potencia = potencia;
        }

        public static void Inicio()
        {
            Coche coche = new Coche("Volkswagen", "Polo", 1, 80.50);
            Console.WriteLine("Marca: " + coche.marca);
            Console.WriteLine("Modelo: " + coche.modelo);
            Console.WriteLine("Cilindrada: " + coche.cilindrada);
            Console.WriteLine("Potencia: " + coche.potencia);
        }

    }
}
