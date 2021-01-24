using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int mePegue = 10;
        public static void Executar()
        {
            // Acessar a variável 'a' dentro do método Executar!
            DesafioAtributo desafioEasy = new DesafioAtributo();    // É necessário instanciar pois estou tentando acessar um item não static, dentro de uma função static.
            Console.WriteLine(desafioEasy.mePegue);
        }
    }
}
