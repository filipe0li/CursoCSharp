using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine($"{dia:D2}/{mes:D2}/{ano}");   // :D2 minimo 2 digitos.
        }
        public static void Executar()
        {
            Formatar(8,8,1991); // Mesma coisa, mas com risco de misturar os valores.
            Formatar(1991, 8, 8);   // Exemplo de bagunça por errar a ordem dos parâmetros.
            Formatar(ano: 1991, dia: 08, mes: 08); // Quando coloco o parâmetro dia: estou me referindo diratamente a int dia e não preciso me preoculpar com a ordem.
        }
    }
}
