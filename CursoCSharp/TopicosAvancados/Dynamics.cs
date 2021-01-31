using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "Teste";    // Tipo dynamic deia atibuir qualquer tipo a ela.
            Console.WriteLine(meuObjeto);
            meuObjeto = 3;                  // Deixou trocar o tipo.
            Console.WriteLine(meuObjeto);
            meuObjeto++;
            Console.WriteLine(meuObjeto);
            meuObjeto = false;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject(); // Deixa ir adicionando itens.  Perceba que não precisei criar um tipo para o objeto.
            aluno.nome = "Maria Júlia";
            aluno.nota = 8.9;
            aluno.idade = 24;

            Console.WriteLine("{0} tirou a nota {1}, e possui {2} anos.", aluno.nome, aluno.nota, aluno.idade);
        }
    }
}
