using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var arquivo = "contas.txt";
            using (var fluxoDoArquivo = new FileStream(arquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDoArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    Console.WriteLine(leitor.Read());
                }
            }

            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer, int qtdBytes)
        {
            var enconding = Encoding.UTF8;
            var texto = enconding.GetString(buffer, 0, qtdBytes);
            Console.Write(texto);
        }
    }
}
