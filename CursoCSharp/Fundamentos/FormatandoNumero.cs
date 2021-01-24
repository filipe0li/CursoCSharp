using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));    // "F1" Formata arredonda para cima.
            Console.WriteLine(valor.ToString("#.##"));  // "#.##" Formatação personalizada e arredonda para cima.
            Console.WriteLine(valor.ToString("C"));    // "C" Formata para moeda local.
            Console.WriteLine(valor.ToString("P"));     // "P" Formata para %.

            CultureInfo cultura = new CultureInfo("pt-BR"); // Especifica moeda para pt-BR.

            Console.WriteLine(valor.ToString("C0", cultura));     // "C0" Formata Moeda sem casas decimais. // cultura formata a moeda especifica.
            Console.WriteLine(valor.ToString("C3", cultura));     // "C0" Formata Moeda com 3 casas decimais.

            int inteiro = 256;

            Console.WriteLine(inteiro.ToString("D10")); // "D10" completa número para ter 10 casas.
        }
    }
}
