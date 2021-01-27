using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
  interface Ponto // Padrão PUBLIC ao contrario da class que é tudo privado.
  {
    void MoverNaDiaginal(int delta);  // Não da para deixar private, pois é uma INTERFACE.
  }
  struct Coordenada: Ponto
  { // Não há necessidade de atribuição a um objeto.
    public int X;
    public int Y;
    public Coordenada(int x, int y) // Construtor com parâmetros
    {
      X = x;
      Y = y;
    }
    public void MoverNaDiaginal(int delta)
    {
      X += delta;
      Y += delta;
    }
  }
    class ExemploStruct
    {
      public static void Executar()
      {
        Coordenada coordenadaInicial; // Não houve necessidade de atribuição a um objeto.
        coordenadaInicial.X = 2;
        coordenadaInicial.Y = 2;

        Console.WriteLine("Cooredenada Inicial:\nX = {0}\nY = {1}", coordenadaInicial.X, coordenadaInicial.Y);

        var coordenadaFinal = new Coordenada(9, 1);
        coordenadaFinal.MoverNaDiaginal(10);

        Console.WriteLine("Coordenada Final :\nX = {0}\nY= {1}", coordenadaFinal.X, coordenadaFinal.Y);
      }
    }
}
