﻿using ByteBankImportacaoExportacao.Modelos;
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

            CriarArquivo();

            Console.ReadLine();
        }

        static void LerContasDeArquivo(string arquivo)
        {
            using (var fluxoDoArquivo = new FileStream(arquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDoArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    Console.WriteLine(ConverterStringParaContaCorrente(leitor.ReadLine()));
                }
            }
        }

        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";
            using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using(var escritor = new StreamWriter(fluxoDoArquivo, Encoding.UTF8))
            {
                var contaComoString = "375,4644,2483.13,Jonatan Test";
                escritor.WriteLine(contaComoString);
            }
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            string[] campos = linha.Split(',');
            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.',',');
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
