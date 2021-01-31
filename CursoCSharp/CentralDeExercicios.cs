using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp
{
    public class CentralDeExercicios
    {
        Dictionary<string, Action> Exercicios;

        public CentralDeExercicios(Dictionary<string, Action> exercicios)
        {
            Exercicios = exercicios;
        }

        public void SelecionarEExecutar()
        {
            int i = 1;

            foreach (var exercicio in Exercicios)
            {
                Console.WriteLine("{0}) {1}", i, exercicio.Key);    // Imprime lista de exerciicios. exercicio.Key é a descrição passada como string no Dictionary central.
                i++;
            }

            Console.Write("Digite o número (ou vazio para o último)? ");

            int.TryParse(Console.ReadLine(), out int num);  // Recebe número do exercicio.
            bool numValido = num > 0 && num <= Exercicios.Count;
            num = numValido ? num - 1 : Exercicios.Count - 1;

            string nomeDoExercicio = Exercicios.ElementAt(num).Key;

            Console.Clear();    // Limpa tela do console.
            Console.Write("Executando exercício "); // 21 número de caracteres passado para Enumerable.
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(nomeDoExercicio);
            Console.ResetColor();   // Reseta cor de fundo.

            Console.WriteLine(String.Concat(
                Enumerable.Repeat("=", nomeDoExercicio.Length + 21)) + "\n");   // cia =========================

            Action executar = Exercicios.ElementAt(num).Value;
            try
            {
                executar();
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ocorreu um erro: {0}", e.Message);
                Console.ResetColor();

                Console.WriteLine(e.StackTrace);    // Imprime erros.
            }
        }
    }
}