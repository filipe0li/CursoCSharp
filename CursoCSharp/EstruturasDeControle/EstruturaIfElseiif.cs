using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElseiif
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota do aluno: ");
            float.TryParse(Console.ReadLine(), out float nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Aluno vai pára o Quadro de Honra!");
            }
            else if (nota >= 7.0/* && nota < 9.0*/) // Se ele não passou no primeiro caso, já siguinifica que é menor que 9.0.
            {
                Console.WriteLine("Aprovado!");
            }
            else if (nota >= 5.0/* && nota < 7.0*/) // Se ele não passou no primeiro e no segundo caso, já siguinifica que é menor que 7.0.
            {
                Console.WriteLine("Recuperação!");
            }
            else
            {
                Console.WriteLine("Reprovado!\nLixo!");
            }
            Console.WriteLine("Fim!");


            //  FORMA ANINHADA

            /*
            if (nota >= 9.0)
            {
                Console.WriteLine("Aluno vai pára o Quadro de Honra!");
            }
            else
            {
                if (nota >= 7.0)
                {
                    Console.WriteLine("Aprovado!");
                }
                else
                {
                    if (nota >= 5.0)
                    {
                        Console.WriteLine("Recuperação!");
                    }
                    else
                    {
                        Console.WriteLine("Reprovado!\nLixo!");
                    }
                }
            }
            Console.WriteLine("Fim!");
            */
        }
    }
}
