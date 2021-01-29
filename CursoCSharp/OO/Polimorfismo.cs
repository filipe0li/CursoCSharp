using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Comida
    {
        public double Peso;

        // Construtor com argumentos.
        public Comida(double peso)
        {
            Peso = peso;
        }

        // Construtor padrão.
        public Comida()
        {

        }
    }
    public class Feijao : Comida
    {
        // Construtor
        public Feijao(double peso) : base(peso) { }
        //public double Peso;
    }
    public class Arroz : Comida
    {
        //public double Peso;
    }

    public class Carne : Comida
    {
        //public double Peso;
    }

    public class Pessoa
    {
        // Embora Comida e Pesoa tenha var Peso em comum, estão em class separadas e Pessoa não Herda de Comida.
        public double Peso;
        // Ao incvez de ficar criando funções para cada tipo de comida, crie uma função genêria, e faça com que todas comidas erdem da classe genêrica.
        public void Comer(Comida comida)
        {
            Peso += comida.Peso;
        }

        //public void Comer(Feijao feijao)
        //{
        //    Peso += feijao.Peso;
        //}

        //public void Comer(Arroz arroz)
        //{
        //    Peso += arroz.Peso;
        //}

        //public void Comer(Carne carne)
        //{
        //    Peso += carne.Peso;
        //}
    }
    class Polimorfismo
    {
        public static void Executar()
        {
            // Feijao tem um construtor
            Feijao ingrediente1 = new Feijao(0.3);

            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25;

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.3;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine("O cliente depois de comer está com {0}kg", cliente.Peso);
        }
    }
}
