using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)   // armazena parâmetros em uma array.
        {
            foreach (var item in caminhos)
            {
                FileInfo arquivo = new FileInfo(item);

                if (arquivo.Exists) // Se esses arquivos existirem delete.
                {
                    arquivo.Delete();
                }
            }
        }
        public static void Executar()
        {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoCopia, caminhoDestino); // Se esses arquivos existirem delete.

            using (StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Arquivo original");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name); // Nome do arquivo
            Console.WriteLine(origem.IsReadOnly);   // É somente leitura?
            Console.WriteLine(origem.FullName); // Caminho completo "url".
            Console.WriteLine(origem.Extension);    // Tipo de arquivo ".txt".
            Console.WriteLine(origem.DirectoryName);    // Pasta do arquivo.

            origem.CopyTo(caminhoCopia);    // Cria uma cópia do arquivo.
            origem.MoveTo(caminhoDestino);  // Move arquivo.
        }
    }
}
