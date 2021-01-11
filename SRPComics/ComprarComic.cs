using System;

namespace SRPComics
{
    public class ComprarComic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Biendo a la tienda de comics");

            Editorial comic = new Editorial();
            comic.Accion();

            Console.WriteLine(comic.Dueño + " " + comic.Titulo);
        }
    }
}
