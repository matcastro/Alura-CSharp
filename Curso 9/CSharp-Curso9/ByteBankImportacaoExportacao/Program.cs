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
            var fluxoDoArquivo = new FileStream(arquivo, FileMode.Open);
            var buffer = new byte[1024];
            var bytesLidos = -1;

            while(bytesLidos != 0)
            {
                bytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }
            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            var enconding = Encoding.UTF8;
            var texto = enconding.GetString(buffer);
            Console.Write(texto);
        }
    }
} 
 