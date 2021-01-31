using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    public class NegativoException : Exception  // NegativeException é uma Exception, Herança.
    {
        // Construtor padrão:
        public NegativoException() { }

        // Construtor que recebe a mesnsagem:
        public NegativoException(string message) : base(message) { }

        // Construtor recebe mesnsagem e recebe outra Exception que pode ter causado Exception, ou seja, se existir uma outra Exception ele não ignora:
        public NegativoException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class ImparExeption : Exception
    {
        // Sobrescreve construtor que recebe a mensagem:
        public ImparExeption(string message) : base(message) { }
    }

    class ExcecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-2, 3);

            if (valor < 0)
            {
                throw new NegativoException("Número negativo... :(");
            }

            if (valor % 2 == 1) // Impar
            {
                throw new ImparExeption("Valor impar... :(");
            }

            return valor;   // Se passou pelos testes quer dizer que é positivo e par.
        }
        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());
            }
            catch (NegativoException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (ImparExeption ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro inesperado");
            }
        }
    }
}
