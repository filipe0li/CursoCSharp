using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            /*
            byte h = 0;

            while (h <= 5)
            {
                Console.WriteLine($"O valor de i é {h}.");
                h++;
            }
            */
            // Mesma coisa que:

            for (byte i = 0; i < 255; i++)
            {
                Console.WriteLine($"O valor de i é {i}.");
            }
            //------------------------------------------//

            Console.Write("Informe o tamanho da turma: ");
            byte.TryParse(Console.ReadLine(), out byte tamanhoDaTurma);
            float somatorio = 0F;

            for (byte i = 1; i <= tamanhoDaTurma; i++)
            {
                Console.Write($"Informe a nota do aluno {i}: ");
                float.TryParse(Console.ReadLine(), out float notaAtual);

                somatorio += notaAtual;
            }

            /*  // Decessente
            for (byte i = tamanhoDaTurma; i >= 1; i--)
            {
                Console.Write($"Informe a nota do aluno {i}: ");
                float.TryParse(Console.ReadLine(), out float notaAtual);

                somatorio += notaAtual;
            }
            */

            float media = tamanhoDaTurma > 0 ? somatorio / tamanhoDaTurma : 0;
            Console.WriteLine($"Média da turma: {media}");

        }
    }
}
