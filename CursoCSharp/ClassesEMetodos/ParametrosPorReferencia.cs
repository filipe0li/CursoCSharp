using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia   // Eles não aceitam referencia com valor padrão, tipo (numero = 0).
    {
        public static void AlterarRef(ref int numero)   // ref faz uma cópia que compartilhada a mesma memória e pode altera o valor original sem precisar fazer um retorn na função.
        {
            numero += 1000;
        }
        public static void AlterarOut(out int numero1, out int numero2)   // out cria um retorno de valor para variavel, desde que a variável não esteja com valor.  Sem precisar fazer um retorn na função.
        {
            numero1 = 0; // precisa inicializar a variável dentro da função!
            numero2 = 0; // precisa inicializar a variável dentro da função!
            numero1 = 30;
            numero2 = 15;
        }
        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);   // ref faz uma cópia que compartilhada a mesma memória e pode altera o valor original sem precisar fazer um retorn na função.
            Console.WriteLine(a);

            int b;  // A variável não pode estar iniciada.
            AlterarOut(out b, out int c);
            Console.WriteLine($"{b}, {c}");
        }
    }
}
