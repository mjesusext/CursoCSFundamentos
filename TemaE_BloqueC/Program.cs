using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaE_BloqueC
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "En un lugar de La Mancha de cuyo nombre no quiero acordarme";
            Console.WriteLine(cadena.EstaVacia());
            Console.WriteLine(cadena.Invertir());
            Console.WriteLine(cadena.Left(11));
            Console.WriteLine(cadena.Right(9));
            Console.ReadLine();
        }
    }
}
