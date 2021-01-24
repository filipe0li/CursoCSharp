using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine($"O número aleatório escolhido foi: {numero}.");

            for (byte i = 1; i <= 50; i++)
            {
                Console.Write($"O número {i} é o número que queremos? ");
                if (i == numero)
                {
                    Console.WriteLine("Sim!");
                    break;  // Sai do laço de repetição1
                }
                else
                {
                    Console.WriteLine("Não!");
                }

            }
            Console.WriteLine("Fim!");
        }
    }
}
