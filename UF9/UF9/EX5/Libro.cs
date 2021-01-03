using System;

namespace UF9
{
    class Libro
    {
        public string autor { get; set; }
        public string titulo { get; set; }
        public string ubicacion { get; set; }

        public Libro()
        {
        }

        public Libro(string autor, string titulo, string ubicacion)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.ubicacion = ubicacion;
        }

    }
}
