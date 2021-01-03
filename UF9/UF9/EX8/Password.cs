using System;
using System.Collections.Generic;
using System.Text;

namespace UF9
{
    class Password
    {
        int longitud;
        string contraseña;

        public Password(int longitud)
        {
            this.longitud = 8;
            this.contraseña = generarContraseña(longitud);
        }

        public string generarContraseña(int lon)
        {
            Random rd = new Random();
            string cont = "";
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            char letra;
            for (int i = 0; i < lon; i++)
            {
                letra = caracteres[rd.Next(caracteres.Length)];
                cont += letra.ToString() ;
            }
            Console.WriteLine("Contraseña: " + cont);
            return cont;
        }


    }
}
