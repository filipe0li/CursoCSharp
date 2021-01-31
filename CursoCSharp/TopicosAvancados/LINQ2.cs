using System;
using System.Collections.Generic;
using System.Linq;  // ajuda pra cacete!
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2 : ListaDeAlunos
    {
        public static void Executar()
        {
            var pedro = alunos.Single(item => item.Nome.Equals("Pedro"));   // Crias um objeto do tipo Aluno que foram setada para "Pedro". Se não existir da ERRO.
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(item => item.Nome.Equals("Fulano"));    // Crias um objeto do tipo Aluno que foram setada para "Fulano". Mas se não existir recebe null.

            Console.WriteLine(fulano != null ? fulano.Nome : "Aluno Inexistente");

            var ana = alunos.First(item => item.Nome.Equals("Ana"));    // Recebe 1º Ana, possui 2.
            Console.WriteLine(ana.Nota);

            var beltrano = alunos.FirstOrDefault(item => item.Nota.Equals("Beltrano"));
            Console.WriteLine(beltrano != null ? beltrano.Nota : "Aluno Inexistente");

            var outraAna = alunos.LastOrDefault(item => item.Nome.Equals("Ana"));
            Console.WriteLine(outraAna != null ? outraAna.Nota : "Aluno Inexistente");

            var exemploSkip = alunos.Skip(1).Take(3);   // Pule 1 pegue 3.

            foreach (var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(item => item.Nota);  // Maior nota.
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(item => item.Nota);   // Menor nota.
            Console.WriteLine(menorNota);

            double somatorioNotas = alunos.Sum(item => item.Nota);     // Soma das notas.
            Console.WriteLine(somatorioNotas);

            double mediaDaTurma = alunos.Where(item => item.Nota >= 7)  // Somente quem tem nota >= 7.
                .Average(item => item.Nota);    // Média das notas, dos aprovados.
            Console.WriteLine(mediaDaTurma.ToString("f"));
        }
    }
}
