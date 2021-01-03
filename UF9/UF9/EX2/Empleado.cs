using System;
using System.Collections.Generic;
using System.Text;

namespace UF9
{
    class Empleado
    {
        public string nombre { get; set; }
        public double sueldo { get; set; }

        public Empleado()
        {
        }

        public Empleado(string nombre, double sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }

        public void ImprimirDatos()
        {
            Console.WriteLine("{0} con sueldo mensual {1} euros", nombre, sueldo);
        }

        public void PagarImpuesto()
        {
            if (sueldo >= 3000)
                Console.WriteLine("{0} tiene que pagar impuesto", nombre);
            else
                Console.WriteLine("{0} no tiene que pagar impuesto", nombre);
        }
    }
}
