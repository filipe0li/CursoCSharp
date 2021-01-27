using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
  public enum Genero  // enum é um tipo personalizado, com valores pre definidos.
  {
    Acao, Aventura, Terror, Animacao, Comedia
  }
  public class Filme
  {
    public string Titulo;
    public Genero GeneroDoFilme;
  }
  class ExemploEnum
  {
    public static void Executar()
    {
      int id = (int)Genero.Animacao;  // Casting no enum.
      Console.WriteLine(id);

      var filmeParaFamilia = new Filme();
      filmeParaFamilia.Titulo = "Sharknardo 17";
      filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

      Console.WriteLine("{0} é {1}", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
    }
  }
}