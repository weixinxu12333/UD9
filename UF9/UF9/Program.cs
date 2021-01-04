using System;

namespace UF9
{
    class Program
    {
        static void Main(string[] args)
        {
            var salir = false;
            var menu = new EasyConsole.Menu()
                .Add("Ex1", () =>
                {
                    Alumno alumno = new Alumno("Weixin", 24);
                    alumno.Imprimir();
                    alumno.MayorDeEdad();
                })
                .Add("Ex2", () =>
                {
                    Empleado empleado = new Empleado("A", 1000.50);
                    empleado.ImprimirDatos();
                    empleado.PagarImpuesto();
                })
                .Add("Ex3", () =>
                {
                    Operaciones op = new Operaciones(10, 5);
                    op.suma();
                    op.resta();
                    op.multiplicar();
                    op.dividir();
                })
                .Add("Ex4", () =>
                {
                    PruebaPersona.Inicio();
                })
                .Add("Ex5", () =>
                {
                    Libro.Inicio();
                })
                .Add("Ex6", () =>
                {
                    Coche.Inicio();
                })
                .Add("Ex7", () =>
                {
                    Person p = new Person("Weixin", 24, "123456789B", "M", 45, 160);
                    p.Imprimir();
                })
                .Add("Ex8", () =>
                {
                    Password psw = new Password(10);
                })
                .Add("Ex9", () =>
                {
                    Electrodomestico el = new Electrodomestico(20, "Negro", 'B', 10);
                    el.Imprimir();
                })
                .Add("Ex10", () =>
                {
                    Serie serie = new Serie("Yanxi Palace: Princess Adventures", "Chinese Drama", "Netflix", 1);
                    Console.WriteLine(serie);
                })
                .Add("Salir", () => salir = true);
            while(!salir)
                menu.Display();
        }
    }
}
