using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class DelegatesComoParametros
    {
        public delegate int Operacao(int n1, int n2);
        public static int Soma(int n1, int n2) => n1 + n2;  // Igual Soma(int n1, int n2) { return n1 + n2;}    => mesma coisa que retorn.

        public static string Calcular(Operacao funcao, int n1, int n2)  // Calcurar recebe uma função com paraâmetros do deleagate.
        {
            var resultado = funcao(n1, n2); // Executa função com parâmetros recebidos e retorno da função recebe resultado.
            return $"Resultado {resultado}";// Imprime resultado.
        }
        public static void Executar()
        {
            Operacao subtracao = (int x, int y) => x - y;
            Console.WriteLine(Calcular(Soma, 3, 2) + "\n");
            Console.WriteLine(Calcular(subtracao, 3, 2));   // Estou enviando a função subtracao com parâmetro 3, 2. Que retorna 3 - 2 = 5.
        }
    }
}
