using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
  {
    double desconto = 0.1;  // double desconto está privado por padrão e não pode ser aterado sem ser publico ou (get, set)
    string nome;
    public string Nome
    { // Regras para acessar / modifucar string Nome.
      get  // AUTORIZA Leitura.
      {
        return "Opcinal: " + nome;  // Toda leitura vira com está regra.
      }
      set  // AUTORIZA Gravação.
      {
        nome = value; // value é o valor / dado que foi passado
      }
    }

    // Propriedade autoimplementada
    public double Preco
    { // Sem regras para acessar / modifucar double Preco.
      get;  // AUTORIZA Leitura.
      set;  // AUTORIZA Gravação.
    }

    // Somente leitura
    public double PrecoComDesconto
    {
      //get => Preco - (desconto * Preco);  // Lambda é a mesma coisa que:
      get  // AUTORIZA SOMENTE Leitura.
      {
        return Preco - (desconto * Preco);
      }
    }
    public CarroOpcional()  // Construtor padrão.
    {

    }
    public CarroOpcional(string nome, double preco)  // Construtor com parâmetros.
    {
      Nome = nome;
      Preco = preco;
    }
  }
  class Props
    {
    public static void Executar()
    {
      var op1 = new CarroOpcional("Ar condicionado", 3499.9);  // Construtor com parâmetros.
      Console.WriteLine(op1.PrecoComDesconto);  //SOMENTE Leitura.

      var op2 = new CarroOpcional();  // Construtor padrão.
      op2.Nome = "Direção Elétrica";
      op2.Preco = 2349.9;
      Console.WriteLine(op1.Nome);
      Console.WriteLine(op1.Preco);

      Console.WriteLine(op2.Nome);
      Console.WriteLine(op2.Preco);
      Console.WriteLine(op2.PrecoComDesconto);
    }
  }
}
