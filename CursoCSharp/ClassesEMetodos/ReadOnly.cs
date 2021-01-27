using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
  public class Cliente
  {
    public string Nome;
    readonly DateTime Nascimento; // const não pode ser atribuido sem um valor inicial, mas readonly pode.
    public Cliente(string nome, DateTime nascimento)  // Costrtor com atributos
    {
      Nome = nome;
      Nascimento = nascimento;
    }

    public string GetDataDeNascimento()
    {
      return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
    }
  }
  class ReadOnly
  {
    public static void Executar() // static, siguinifica que não preciso criar um opjeto para acessar a função (não precisa instanciar).
    { // public torna a função visivel para que em outro namespace eu consiga ter acesso a ela. void sem retorno (tipo retorno, sempre antes, ao lado do nome da função).
      var novoCliente = new Cliente("Ana Silva", new DateTime(/*1987, 5, 22*/day: 22, month: 5, year: 1987));  // Ano, mês, dia.

      Console.WriteLine(novoCliente.Nome);
      Console.WriteLine(novoCliente.GetDataDeNascimento());
      // novoCliente.Nascimento = new DateTime(day: 8, month: 8, year: 1991); // não pode ser atribuido diretamente pois é readolnly.
      var novoCliente2 = new Cliente("Filipe", new DateTime(day: 8, month: 8, year: 1991)); // Mas pode ser atribuido atravaz de uma instancia, objeto.
      Console.WriteLine(novoCliente2.Nome);
      Console.WriteLine(novoCliente2.GetDataDeNascimento());
    }
  }
}
