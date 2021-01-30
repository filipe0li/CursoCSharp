using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    static class ExtensoesInteiro
    {
        public static int Soma(this int num, int outroNumero)   // this recebe num por extensão '.'(ponto).
        {
            return num + outroNumero;
        }

        public static double Subtracao(this double num, int outroNumero)
        {
            return num - outroNumero;
        }
    }
    class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 5;
            double numeroDouble = 5.5;
            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numeroDouble.Subtracao(10));

            Console.WriteLine(2.Soma(3));   // Exemplo: 2(Recepito por extensão).Soma(3(recebido por parâmetro))
            Console.WriteLine(2.9.Subtracao(4));
        }
    }
}
