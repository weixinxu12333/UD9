using System;

namespace UF9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alumno alumno = new Alumno("Weixin", 24);
            //alumno.Imprimir();
            //alumno.MayorDeEdad();

            Empleado empleado = new Empleado("A", 1000.50);
            empleado.ImprimirDatos();
            empleado.PagarImpuesto();

            Empleado empleado2 = new Empleado();
            empleado2.nombre = "B";
            empleado2.sueldo = 3000;
            empleado2.ImprimirDatos();
            empleado2.PagarImpuesto();

        }
    }
}
