using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoreRelacinais
    {
        public static void Executar()
        {
            //double nota = 6.0;
            Console.Write("Qual a sua nota? ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            Console.WriteLine($"Nota inválida? {nota > 10.0}"); // Maior q >.
            Console.WriteLine($"Nota inválida? {nota < 0.0}");  // Menor q <.
            Console.WriteLine($"Nota Maxima? {nota == 10.0}");  // igual ha ==.
            Console.WriteLine($"Tem como melhorar a nota? {nota != 10.0}"); // Diferente de !=.
            Console.WriteLine($"Passou por média? {nota >= notaDeCorte}");  // Maior ou igual ha >=.
            Console.WriteLine($"Recuperação? {nota < notaDeCorte}");    // Menor q <.
            Console.WriteLine($"Reprovado? {nota <= 3.0}");   // Menor ou igual ha <=.

        }
    }
}
