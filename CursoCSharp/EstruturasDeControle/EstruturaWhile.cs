using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numerEncontrado = false;
            byte tentativasRestantes = 5;

            while (tentativasRestantes > 0 && !numerEncontrado)
            {
                Console.Write("Insira um número entre 1 - 16: ");
                byte.TryParse(Console.ReadLine(), out byte palpite);
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Parabens!\nO número foi encontrado na {5 - tentativasRestantes}º tentativa.");
                    numerEncontrado = true;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Um pouco menos... Tente novamente!\nVocê tem só mais {tentativasRestantes} Chances!");

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Um pouco mais... Tente novamente!\nVocê tem só mais {tentativasRestantes} Chances!");
                }
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}
