using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            int valorNegativo = -5;
            int numero1 = 2;
            int numero2 = 3;
            bool booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            numero1++;
            Console.WriteLine(numero1);

            --numero1;  // Mesma coisa que numero1--; Mas será feita a operação no caso -- antes de qualquer comparação.
            Console.WriteLine(numero1);

            Console.WriteLine($"numero1 = {numero1}\nnumero2 = {numero2}" + // Valores antes da comparação.
                $"\n{numero1++ == --numero2}" +  // No caso numero1 = 2 e numero2 = 3, mas numero2 sera decrementado antes da comparação == e se tornara 2, resultando em true.
                $"\nnumero1 = {numero1}\nnumero2 = {numero2}"); // Valores depois da comparação, somente depois da comparação numero1 = 3..


        }
    }
}
