using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    public class Aluno  // Cria tipo Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    class ListaDeAlunos
    {
        protected static List<Aluno> alunos = new List<Aluno>()
            {
                new Aluno()
                {
                    Nome = "Pedro", Idade = 24, Nota = 8.0
                },
                new Aluno()
                {
                    Nome = "Andre", Idade = 21, Nota = 4.3
                },
                new Aluno()
                {
                    Nome = "Ana", Idade = 25, Nota = 9.5
                },
                new Aluno()
                {
                    Nome = "Jorge", Idade = 20, Nota = 8.5
                },
                new Aluno()
                {
                    Nome = "Ana", Idade = 21, Nota = 7.7
                },
                new Aluno()
                {
                    Nome = "Julia", Idade = 22, Nota = 7.5
                },
                new Aluno()
                {
                    Nome = "Marcio", Idade = 18, Nota = 6.8
                }
            };
    }

    class LINQ1 : ListaDeAlunos
    {
        public static void Executar()
        {
            Console.WriteLine("======== Aprovados ========");

            // Filtro enviando uma função:
            //Where Cria uma função. Para cada item dentro de alunos, os que passarem no teste da função ele retorna para aprovados. .OrderBy organiza.
            var aprovados = alunos.Where(item => item.Nota >= 7).OrderBy(item => -item.Nota);   /* -item indica que é reverso */

            foreach (var item in aprovados)
            {
                Console.WriteLine(item.Nome);   // Neste ainda é um objeto.
            }

            Console.WriteLine("\n======== Chamada ========");
            var chamada = alunos.OrderBy(item => item.Nome).Select(item => item.Nome);  // .Select retorna somente uma arrey de dtring contendo os Nomes.

            foreach (var item in chamada)
            {
                Console.WriteLine(item);    // Neste é somente um item de uma array.
            }

            Console.WriteLine("======== Aprovados (por Idade) ========");

            // Usando LINQ:
            var alunosAprovados =
        from aluno in alunos
        where aluno.Nota >= 7
        orderby aluno.Idade
        select aluno.Nome;
            // Isto foi escrito em SQL, usando LINQ fez a mesma coisa que o chamada.

            foreach (var item in alunosAprovados)
            {
                Console.WriteLine(item);
            }
        }
    }
}
