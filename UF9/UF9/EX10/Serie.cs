using System;
using System.Collections.Generic;
using System.Text;

namespace UF9
{
    class Serie
    {
        private string titulo, genero, creador;
        private int numTemporadas = 3;
        private bool entregado = false;

        public Serie()
        {
        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
        }

        public Serie(string titulo, string genero, string creador, int numTemporadas)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.creador = creador;
            this.numTemporadas = numTemporadas;
        }

        public override string ToString()
        {
            return @$"
Titulo: {this.titulo}
Genero: {this.genero}
Creador: {this.creador}
Temporadas: {this.numTemporadas}
Entregado: {(this.entregado ? "Si" : "No")}
";
        }
    }
}
