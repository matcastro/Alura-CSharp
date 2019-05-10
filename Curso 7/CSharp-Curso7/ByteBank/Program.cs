using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente(2);
            lista.imprimeLista();

            lista.Adicionar(new ContaCorrente(1, 123));
            lista.Adicionar(new ContaCorrente(1, 456));
            lista.Adicionar(new ContaCorrente(1, 789));
            lista.Adicionar(new ContaCorrente(2, 123));
            lista.Adicionar(new ContaCorrente(2, 456));

            lista.imprimeLista();
            lista.Remover(new ContaCorrente(1, 456));
            lista.imprimeLista();
            //lista.Adicionar(new ContaCorrente(2, 789));
            //lista.Adicionar(new ContaCorrente(1, 123));
            //lista.Adicionar(new ContaCorrente(1, 456));
            //lista.Adicionar(new ContaCorrente(1, 789));
            //lista.Adicionar(new ContaCorrente(2, 123));
            //lista.Adicionar(new ContaCorrente(2, 456));
            //lista.Adicionar(new ContaCorrente(2, 789));
            //lista.Adicionar(new ContaCorrente(1, 123));
            //lista.Adicionar(new ContaCorrente(1, 456));
            //lista.Adicionar(new ContaCorrente(1, 789));
            //lista.Adicionar(new ContaCorrente(2, 123));
            //lista.Adicionar(new ContaCorrente(2, 456));
            //lista.Adicionar(new ContaCorrente(2, 789));

            Console.ReadLine();
        }

        static void TestaArrayInt()
        {
            int[] idades = new int[] { 15, 28, 35, 50, 28 };

            int acumulador = 0;

            for (int indice = 0; indice < idades.Length; indice++)
            {
                acumulador += idades[indice];
                Console.WriteLine($"Valor no indice {indice} {idades[indice]}");
            }

            int media = acumulador / idades.Length;
            Console.WriteLine(acumulador);
            Console.WriteLine(media);
        }
    }
}
