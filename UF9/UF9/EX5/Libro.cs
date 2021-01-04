using System;

namespace UF9
{
    class Libro
    {
        public string autor { get; set; }
        public string titulo { get; set; }
        public string ubicacion { get; set; }

        public Libro(string autor, string titulo, string ubicacion)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.ubicacion = ubicacion;
        }

        public static void Inicio()
        {
            Libro libro = new Libro("J.K. Rowling", "Harry Potter", "Inglaterra");
            Console.WriteLine("Autor: " + libro.autor);
            Console.WriteLine("Titulo: " + libro.titulo);
            Console.WriteLine("Ubicacion: " + libro.ubicacion);
        }

    }
}
