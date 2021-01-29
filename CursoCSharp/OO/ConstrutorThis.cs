using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)  // construtor
        {
            Nome = nome;
        }
    }
    public class Cachorro : Animal  // Cachorro : (herda) Animal
    {
        public double Altura { get; set; }
        public Cachorro(string nome) : base(nome)
        { // construtor que aponta para Animal. // 1 construtor deve chamar o base.
            Console.WriteLine("Cachorro {0}, foi inicializado!", nome);
        }
        public Cachorro(string nome, double altura) : this(nome)
        { // construtor que aponta para propria class.
            Altura = altura;
        }
        public override string ToString() // Personaliza a conversão de um objeto para string.
        {
            return Nome + " tem " + Altura + "cm de altura.";
        }
    }
    class ConstrutorThis
    {
        public static void Executar()
        {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40.5);

            Console.WriteLine(spike);
            Console.WriteLine(max.ToString()); // .ToStrig(), não precisa ser chamado explicitamente.
        }
    }
}
