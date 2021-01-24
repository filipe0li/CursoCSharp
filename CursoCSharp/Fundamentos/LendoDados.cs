using System;
using System.Collections.Generic;
using System.Globalization; // Chamada para função que substitui ponto por virgula.
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Substitui ponto por virgula.

            Console.WriteLine($"Seu nome é {nome}, você tem {idade} e recebe R$ {salario}");
        }
    }
}
