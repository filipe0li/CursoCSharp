using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + " reais.");

            Console.WriteLine("O {0} da marca {1} custa {2} reais.", nome, marca, preco);

            Console.WriteLine($"O {nome} da marca {marca} custa {preco} reais.");   // $ na frente deixa colocar o nome da variavel dentro.

            Console.WriteLine($"1 + 1 = {1 + 1}!");

        }
    }
}
