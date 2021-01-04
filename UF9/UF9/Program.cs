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

            //Empleado empleado = new Empleado("A", 1000.50);
            //empleado.ImprimirDatos();
            //empleado.PagarImpuesto();

            //Operaciones op = new Operaciones(10,5);
            //op.suma();
            //op.resta();
            //op.multiplicar();
            //op.dividir();

            //PruebaPersona.Inicio();

            //Libro.Inicio();

            //Coche.Inicio();

            //Person p = new Person("Weixin", 24, "123456789B", "M", 45, 160);
            //p.Imprimir();

            // Password psw = new Password(10);

            Electrodomestico el = new Electrodomestico(20, "Negro", 'B', 10);
            el.Imprimir();
        }
    }
}
