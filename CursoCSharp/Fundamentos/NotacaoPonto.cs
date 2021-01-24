using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá".ToUpper().Insert(3/*pos 0= O, pos 1= l, pos2= á, pos 3=  World!*/, " World!").Replace("World", "Mundo");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;

            Console.WriteLine(valorImportante?.Length); // ? Só será acesado se estiiver definido SEGURAÇA!!.
        }
    }
}
