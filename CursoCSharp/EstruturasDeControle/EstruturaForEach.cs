using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            string palavra = "opa!";

            foreach (char letra in palavra) // É importante utilizar o tipo correto para programa ficar leve!
                // Foreach faz com que cada "letra (item)" da variavel (string palavra), seja o proprio "letra (item)", assim dando para usar cada item individualmete, sem precisar fazer um for.
            {
                Console.WriteLine(letra);
            }

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
