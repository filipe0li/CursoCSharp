using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class LambdasDelegate
    {
        // delegate => É um TIPO que armazena a assinatura (TIPO de parâmtros entrada e retorno) de uma função.
        delegate double Operacao(double x, double y);
        public static void Executar()
        {
            Operacao soma = (x, y) => x + y;
            Operacao subtracao = (x, y) => x - y;
            Operacao multiplicacao = (x, y) => x * y;

            Console.WriteLine(soma(3, 3));
            Console.WriteLine(subtracao(5, 2));
            Console.WriteLine(multiplicacao(3, 10));
        }
    }
}
