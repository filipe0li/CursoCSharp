using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public abstract class Celular   // abstract => Necessário para ter método abstract.
    {
        public abstract string Assistente();    // Método(Função) Abstrata => Sem corpo(quem herdar terá que implementar o corpo), toda class que herdar de Celular terá o método Assistente().

        public string Tocar()
        {
            return "Trim ttrim trim...";
        }
    }
    public class Sansung : Celular
    {
        // override => Necessário pois a função Assistente está inacabada.
        public override string Assistente()
    {
            return "Olá! Meu nome é Bixby!";
    }
    }
    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Siri!";
        }
    }
class Abstract
    {

        public static void Executar()
        {
            //Celular c = new Celurar();    // abstract => Não deixa instanciar.
            var Celulares = new List<Celular>
                {
                    new Iphone(),
                    new Sansung()
                };

            foreach (var celular in Celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
