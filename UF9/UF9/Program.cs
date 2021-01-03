using System;

namespace UF9
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno("Weixin", 24);
            alumno.Imprimir();
            alumno.MayorDeEdad();

        }
    }
}
