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
            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");
            Console.WriteLine("Arquivo escrevendoComAClasseFile.txt criado!");

            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);

            Console.ReadLine();
        }

        static void TestaStreamDoConsole()
        {
            using (var fluxoDoArquivo = new FileStream("entradaConsole.txt", FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDoArquivo))
            {
                var buffer = new byte[1024];
                while (true)
                {
                    Console.WriteLine("Escreva seu nome:");
                    var nome = Console.ReadLine();
                    escritor.WriteLine(nome);
                    escritor.Flush();
                }
            }
        }
        static void TestaLeituraBinaria()
        {
            var caminhoArquivo = "teste.txt";
            using (var fluxoDoArquivo = new FileStream(caminhoArquivo, FileMode.Open))
            using (var leitor = new BinaryReader(fluxoDoArquivo))
            {
                Console.WriteLine(leitor.ReadInt32());
                Console.WriteLine(leitor.ReadInt32());
                Console.WriteLine(leitor.ReadDouble());
                Console.WriteLine(leitor.ReadString());
            }
        }
        static void TestaEscritaBinaria()
        {
            var caminhoArquivo = "teste.txt";
            using (var fluxoDoArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new BinaryWriter(fluxoDoArquivo))
            {
                escritor.Write(456);
                escritor.Write(5645646);
                escritor.Write(4000.50);
                escritor.Write("Teste teste");
            }
        }

        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";
            using (var fluxoDoArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDoArquivo))
            {
                for (int i = 0; i < 10000; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    escritor.Flush();
                    Console.WriteLine($"Linha {i}");
                    Console.ReadLine();
                }
            }
        }

        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";
            using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDoArquivo, Encoding.UTF8))
            {
                var contaComoString = "375,4644,2483.13,Jonatan Test";
                escritor.WriteLine(contaComoString);
            }
        }
        static void LerContasDeArquivo()
        {
            var arquivo = "contas.txt";
            using (var fluxoDoArquivo = new FileStream(arquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDoArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    Console.WriteLine(ConverterStringParaContaCorrente(leitor.ReadLine()));
                }
            }
        }


        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            string[] campos = linha.Split(',');
            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nome = campos[3];

            var conta = new ContaCorrente(int.Parse(agencia), int.Parse(numero));
            conta.Depositar(double.Parse(saldo));

            var titular = new Cliente();
            titular.Nome = nome;
            conta.Titular = titular;

            return conta;
        }

        static void EscreverBuffer(byte[] buffer, int qtdBytes)
        {
            var enconding = Encoding.UTF8;
            var texto = enconding.GetString(buffer, 0, qtdBytes);
            Console.Write(texto);
        }
    }
}
