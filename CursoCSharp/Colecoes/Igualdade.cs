using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);

            Console.WriteLine(p1 == p2);    // Embora tenham o mesmo valor, ocupam espaços de memória diferentes.
            Console.WriteLine(p1.Equals(p2));   // Compara igual o ==, mas pode ser personalizado.

            var p3 = p2;    // Compartilham o mesmo espaço de meméria.
            Console.WriteLine(p3 == p2);    // São a mesma coisa, pois estão no mesmo lugar de memória.
        }
    }
}
