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

            //Empleado empleado2 = new Empleado();
            //empleado2.nombre = "B";
            //empleado2.sueldo = 3000;
            //empleado2.ImprimirDatos();
            //empleado2.PagarImpuesto();

            //Operaciones op = new Operaciones(10,5);
            //op.suma();
            //op.resta();
            //op.multiplicar();
            //op.dividir();

            //PruebaPersona pruebaPersona = new PruebaPersona();
            //pruebaPersona.Inicio();

            Libro libro = new Libro("J.K. Rowling", "Harry Potter", "Inglaterra");
            Console.WriteLine("Autor: " + libro.autor);
            Console.WriteLine("Titulo: " + libro.titulo);
            Console.WriteLine("Ubicacion: " + libro.ubicacion);
        }
    }
}
