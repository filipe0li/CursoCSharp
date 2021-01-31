using System;
using CursoCSharp.ClassesEMetodos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    public class Caixa<T>
    {
        T valorPrivado; // T é um tipo temporario.
        public T Coisa { get; set; }

        public Caixa(T coisa)   // Construtor
        {
            Coisa = coisa;
            valorPrivado = coisa;
        }

        public T metodoGenerico(T valor) => new Random().Next(0, 2) == 0 ? Coisa : valor;   // 50/50 ou cai valor passado ou Coisa atribuido no construtor.

        public T GetValor() => valorPrivado;
    }

    class CaixaInt : Caixa<int> // Tem que especificar o tipo T.
    {
        public CaixaInt() : base(0) { }
    }

    class CaixaProduto : Caixa<Produto> 
    {
        public CaixaProduto() : base(new Produto()) { }
    }

    class Genericos
    {
        public static void Executar()
        {
            var caixa1 = new Caixa<int>(1000);  // Tem que especificar o tipo T.
            Console.WriteLine(caixa1.metodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType());

            var caixa2 = new Caixa<string>("Enviado para o construtor!");
            Console.WriteLine(caixa2.metodoGenerico("Enviado para a função!"));
            Console.WriteLine(caixa2.Coisa.GetType());

            CaixaProduto caixa3 = new CaixaProduto();
            Console.WriteLine(caixa3.Coisa.GetType().Name);
        }
    }
}
