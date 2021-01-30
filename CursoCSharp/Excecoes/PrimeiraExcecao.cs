using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    public class Conta
    {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }
        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente!"); // throw Lança uma exceção! Diz que aconteceu um erro!
            }
            Saldo -= valor;
        }
    }
    class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_233.45);    // '_' é opcional, só um separador.

            try    // Tente fazer isso:
            {
                conta.Sacar(1600);
                Console.WriteLine("Retirada efetuado com secesso!");
            }
            catch (Exception ex)    // catch recebe a exceção (Exception ex) (no caso ArgumentException()) e faça:
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name);   // Tipo de erro recebido.
            }
            finally     // Sempre será executado!
            {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
