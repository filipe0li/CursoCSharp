using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro // Construtor, construtores SEMPRE tem o mesmo nome da class
    {
        public string Modelo;
        public string Fabricante;
        public short Ano;

        public Carro(string modelo, string fabricante, short ano)  // Construtor vai retornar uma instancia ao qual ele pertence, não precisa especificar tipo.
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
        public Carro()  // Quando já existe um construtor com atributos é necessário criar um construtor vazio para ter acesso ao construtor sem atributos.
        {

        }
    }

    class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro();   // Utiliza construtor sem atributos.    // new ==> Siguinifica que você vai se basiar no construtor, no caso Carro.
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;

            Console.WriteLine($"{carro1.Fabricante}\t{carro1.Modelo}\t{carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"{carro2.Fabricante}\t{carro2.Modelo}\t{carro2.Ano}");   // Utiliza construtor com atributos.

            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019,
            };
            Console.WriteLine($"{carro3.Fabricante}\t{carro3.Modelo}\t{carro3.Ano}");   // Não utiliza construtor nunhum.
        }
    }
}
