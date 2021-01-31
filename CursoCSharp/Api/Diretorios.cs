using System;
using System.IO;

namespace CursoCSharp.Api
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"D:\CursoCSharp\CursoCSharp";

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true); // Deleta tudo.
            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir)); // Exibe data de criação da pasta novoDir.

            Console.WriteLine("============== PASTAS ==============");
            var pastas = Directory.GetDirectories(dirProjeto);  // Armazena nomes das pastas no array.

            foreach (var item in pastas)
            {
                Console.WriteLine(item);    // Imprime Nomes.
            }

            Console.WriteLine("\n============= ARQUIVOS =============");
            var arquivos = Directory.GetFiles(dirProjeto);  // Armazena nomes dos arquivos no array.

            foreach (var item in arquivos)
            {
                Console.WriteLine(item);    // Imprime Nomes.
            }

            Console.WriteLine("\n============= RAIZ =============");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));  // Informa drive onde a pasta se encontra.

            Directory.Move(novoDir, novoDirDestino);    // move pasta novoDir para local novoDirDestino.
        }
    }
}
