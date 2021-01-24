using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperdorTernario
    {
        public static void Executar()
        {
            float nota = 7.0f;
            bool bomComportamento = true;

            string resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";  // nota >= 7.0 ==> if(nota >= 7.0 && bomComportamento), ? "Aprovado" ==> {"Aprovado"}, :  "Reprovado" ==> else {"Reprovado"};
            Console.WriteLine(resultado);

        }
    }
}
