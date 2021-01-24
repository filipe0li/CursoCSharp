using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.Write("Avalie meu atendimento com uma nota de 0 a 5: ");
            byte.TryParse(Console.ReadLine(), out byte nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Péssiiimo.");
                    break;

                case 1: // Não foi colocado break; Vai passar para o proximo caso.
                case 2: // Não é necessário abrir {} pos só para quando encontra o break.
                    Console.WriteLine("Ruim.");
                    break;

                case 3:
                    Console.WriteLine("Regular.");
                    break;

                case 4:
                    Console.WriteLine("Bom.");
                    break;

                case 5:
                    Console.WriteLine("Ótimo.");
                    break;

                default:    // Como não caiu em nenhum caso defaut é acionado.
                    Console.WriteLine("Nota inválida.");
                    break;
            }
            Console.WriteLine("Obrigado por avaliar!");
        }
    }
}
