using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class MetodosEstaticos
    {
        public class CalculadoraEstatica
        {
            // Método de CLASSE / ESTÁTICO:
            public static int Somar(int a, int b)   // static só pode haver uma cópia (ele pertence a class), não pode agregar ela há uma variavel
            {
                return a + b;
            }
            // Método de INSTÂNCIA:
            public int Multiplicar(int a, int b)
            {
                return a * b;
            }
        }
        public static void Executar()
        {
            Console.WriteLine($"O resultado de 2 + 2 é: {CalculadoraEstatica.Somar(2, 2)}");    // Não houve necessidade de criar um new (cópia) graças ao static

            CalculadoraEstatica calcEst = new CalculadoraEstatica();    // Não possi static e não pode ser acessado diretamente, é obrigatório instanciar (addicionar a um variavel antes).
            Console.WriteLine($"O resultado de 2 * 2 é: {calcEst.Multiplicar(2, 2)}");

            // EXEMPLO!
            Random random = new Random();   // Random não é estático e precisa ser instanciado!
            random.Next(0, 1);
        }
    }
}
