using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class DelegateFunAnonima
    {
        delegate string StringOperacao(string texto);
        public static void Executar()
        {
            StringOperacao inverter = delegate (string palavra) // Função Anônima
            {
                char[] arrayContainer = palavra.ToCharArray();
                Array.Reverse(arrayContainer);    // Inverte a ordem dos itens do array.
                return new string(arrayContainer);
            };
            Console.WriteLine(inverter("C# é Show!"));
        }
    }
}
