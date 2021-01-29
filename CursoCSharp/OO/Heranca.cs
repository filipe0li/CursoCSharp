using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }
        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;
            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }
        public virtual int Acelerar() // visrtual indica que a função pode ser sobrescrita. Estamos fazendo isto em Ferrari
        {
            return AlterarVelocidade(5);
        }
        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }
    public class Uno : Carro  // Uno Herda de carro.
    {
        public Uno() : base(200)
        {  // Como carro não possui seu construtor padrão sem argumentos, é obrigatório que Uno tenha referência ao contrutor com argumentos de Carro(int velocidadeMaxima).

        }
    }
    public class Ferrari : Carro  // Uno Herda de carro.
    {
        public Ferrari() : base(350)
        {  // Como carro não possui seu construtor padrão sem argumentos, é obrigatório que Ferrari tenha referência ao contrutor com argumentos de Carro(int velocidadeMaxima).
        }

        public override int Acelerar() // override Sobrescreve código da class pai (Carro).  Funciona quando o tipo não é Ferrari.
        { // Ferrari alterou permanete dentro de ferrari a função acelerar.
            return AlterarVelocidade(15);
        }

        public new int Frear()  // new Substitui / "ESCONDE" função frear da class Carro. // Não funciona quando o tipo não é Ferrari.
        { // Quando o tipo for Carro vai não vai funcionar.
            return AlterarVelocidade(-15);
        }
    }
    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno....");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine();
            Console.WriteLine("Ferrari....");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine();
            Console.WriteLine("Ferrari com tipo Carro....");
            Carro carro3 = new Ferrari(); // Pilimorfismo, reaproveitamento de tipo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine();
            Console.WriteLine("Uno com tipo Carro....");
            /*Carro*/
            carro3 = new Uno(); // Pilimorfismo, reaproveitamento de tipo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine();
        }
    }
}
