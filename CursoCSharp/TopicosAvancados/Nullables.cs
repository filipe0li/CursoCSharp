using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class Nullables
    {
        static int num4; // Tipo int não inicializadas fora da class são atibuidas com valor 0.
        public static void Executar()
        {
            // Cria valor null em tipos que não aceitam null:
            Nullable<int> num1 = null;
            int? num2 = null;

            //int num3;
            // Não pode usar tipo int sem atribuir valor.
            //Console.WriteLine(num3);

            // Fora da class
            Console.WriteLine(num4);

            Console.WriteLine(num1.HasValue ? "Valor de num " + num1 : "A variavél não possui valor!");

            int valor = num1 ?? 1;  // ?? atribui valor padrão.
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();  // Se for null .GetValueOrDefault() retorna false.
            Console.WriteLine(resultado);

            try
            {
                int x = num1.Value;
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
