using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametroPadrao
    {
        public static int Somar(int a = 1, int b = 1)
        {
            return a + b;
        }
        public static void Executar()
        {
            Console.WriteLine(Somar()); // Se não passar  parâmetro ele assume 1.
            Console.WriteLine(Somar(10, 23));   // normal retorna a soma.
            Console.WriteLine(Somar(b: 5));   //    Escolho qual parâmetro quero atribuir valor.
            Console.WriteLine(Somar(50));   //  O primeiro valor será atribuido no caso a.
        }
    }
}
