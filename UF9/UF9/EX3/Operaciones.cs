using System;
using System.Collections.Generic;
using System.Text;

namespace UF9
{
    class Operaciones
    {
        private int val1 { get; set; }
        private int val2 { get; set; }

        public Operaciones(int val1, int val2)
        {
            this.val1 = val1;
            this.val2 = val2;
        }

        public void suma()
        {
            int res = val1 + val2;
            Console.WriteLine("suma = " + res);
        }

        public void resta()
        {
            int res = val1 - val2;
            Console.WriteLine("resta = " + res);
        }

        public void multiplicar()
        {
            int res = val1 * val2;
            Console.WriteLine("multiplicar = " + res);
        }

        public void dividir()
        {
            double res = (double)val1 / val2;
            Console.WriteLine("dividir = " + res);
        }
    }
}
