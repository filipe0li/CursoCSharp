using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoContinue
    {
        public static void Executar()
        {
            Console.Write("Digete o primeiro número do intervalo: ");
            byte.TryParse(Console.ReadLine(), out byte intervalo1);

            Console.Write("Digete o segundo número do intervalo: ");
            byte.TryParse(Console.ReadLine(), out byte intervalo2);

            Console.WriteLine($"Os números pares entre {intervalo1} e {intervalo2}!");

            for (byte i = intervalo1; i <= intervalo2; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.Write($"{i} ");
            }
        }
    }
}
