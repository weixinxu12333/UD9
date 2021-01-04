using System;
using System.Collections.Generic;
using System.Text;

namespace UF9
{
    class PruebaPersona
    {
        public static void Inicio()
        {
            Persona p1 = new Persona();
            p1.SetNombre("Weixin");
            p1.Saludar();
            Persona p2 = new Persona();
            p1.SetNombre("Jose");
            p1.Saludar();
        }
    }
}
