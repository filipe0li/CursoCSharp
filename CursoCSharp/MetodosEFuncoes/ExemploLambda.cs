using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            // Action não possui retorno é void.
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#");
            };

            algoNoConsole();

            // Func<RETORNO> obrigatóriamente possui retorno.
            Func<int> jogaDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);  // De 1 até 6.
            };

            Console.WriteLine(jogaDado());

            // Func<ENTRADA, RETORNO>
            // Se não abrir {corpo}, não precisa colocar return na Lambda.
            Func<int, string> conversorHex = (numero) => numero.ToString("X");  // Converte para Hexadecimal.

            Console.WriteLine(conversorHex(1234));

            // Func<ENTRADA, ENTRADA, ENTRADA, RETORNO> // Ultimo sempre é o retorno!
            Func<int, int, int, string> formatarDacta = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);

            Console.WriteLine(formatarDacta(8, 8, 1991));
        }
    }
}
