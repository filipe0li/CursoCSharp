using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            int num1 = 3;
            num1 = 7;
            num1 += 10; // num1 = num1 + 10;
            num1 -= 3;  // num1 = num1 - 3;
            num1 *= 5;  // num1 = num1 * 5;
            num1 /= 2;  // num1 = num1 / 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;
            a++;    // a = a + 1;
            b--;    // b = b - 1;
            Console.WriteLine($"a = {a}\nb = {b}");

            dynamic c = new System.Dynamic.ExpandoObject();

            c.nome = "Filipe";

            dynamic d = c;  // Quando é dynamic e d = c; ambos compartilham da mesma memória e mudam junto.
            d.nome = "Thamara";

            Console.WriteLine(c.nome);
        }
    }
}
