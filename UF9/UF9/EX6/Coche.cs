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

        public Coche()
        {
        }

        public Coche(string marca, string modelo, int cilindrada, double potencia)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cilindrada = cilindrada;
            this.potencia = potencia;
        }
    }
}
