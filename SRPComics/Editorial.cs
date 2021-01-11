using System;
using System.Collections.Generic;
using System.Text;

namespace SRPComics
{
    class Editorial
    {
            public string  Dueño = "DC COMICS";

        public string Titulo { get; internal set; }

        public void Accion()
            {
                Console.WriteLine("Compraste el comic Batman");
            }
    }
}
