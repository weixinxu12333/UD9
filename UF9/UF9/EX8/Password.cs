using System;
using System.Collections.Generic;
using System.Text;

namespace UF9
{
    class Password
    {
        int longitud = 8;
        string contraseña;

        public Password()
        {
        }

        public Password(int longitud)
        {
            this.longitud = longitud;
            this.contraseña = generarContraseña();
        }

        private string generarContraseña()
        {
            Random rd = new Random();
            string cont = "";
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            char letra;
            for (int i = 0; i < longitud; i++)
            {
                letra = caracteres[rd.Next(caracteres.Length)];
                cont += letra.ToString();
            }
            Console.WriteLine("Contraseña: " + cont);
            return cont;
        }


    }
}
