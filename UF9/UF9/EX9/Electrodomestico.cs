using System;
using System.Linq;

namespace UF9
{
    class Electrodomestico
    {
        const double PRECIO_BASE = 100;
        const string COLOR = "BLANCO";
        const char CONSUMO = 'F';
        const double PESO = 5;

        private static readonly string[] COLORES = { "BLANCO", "NEGRO", "ROJO", "AZUL", "GRIS" };
        private static readonly char[] CONSUMOS = { 'A', 'B', 'C', 'D', 'E', 'F' };

        protected double precio_base { get; set; } = PRECIO_BASE;
        protected string color { get; set; } = COLOR;
        protected char consumo { get; set; } = CONSUMO;
        protected double peso { get; set; } = PESO;


        public Electrodomestico() { }

        public Electrodomestico(double precio_base, double peso)
        {
            this.precio_base = precio_base;
            this.peso = peso;
        }

        public Electrodomestico(double precio_base, string color, char consumo, double peso)
        {
            this.precio_base = precio_base;
            this.color = validarColor(color);
            this.consumo = validarConsumo(consumo);
            this.peso = peso;
        }

        public string validarColor(string color)
        {
            if (!COLORES.Contains(color.Trim().ToUpper()))
                return COLOR;
            return color.Trim().ToUpper();
        }

        public char validarConsumo(char consumo)
        {
            if (!CONSUMOS.Contains(Char.ToUpper(consumo)))
                return CONSUMO;
            return Char.ToUpper(consumo);
        }

        public void Imprimir()
        {
            Console.WriteLine(precio_base);
            Console.WriteLine(color);
            Console.WriteLine(consumo);
            Console.WriteLine(peso);
        }
    }
}
