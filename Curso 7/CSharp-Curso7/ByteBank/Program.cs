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
            Lista<int> lista = new Lista<int>();

            lista.AdicionarVarios(16, 63, 52, 94);
            lista.Remover(63);

            Lista<string> cursos = new Lista<string>();
            cursos.AdicionarVarios("C# Parte 1", "C# Parte 2", "C# Parte 3");

            Lista<ContaCorrente> contas = new Lista<ContaCorrente>();
            contas.AdicionarVarios(new ContaCorrente(124, 54354), new ContaCorrente(201, 44354));

            for (int i = 0; i < lista.Tamanho; i++)
            {
                Console.WriteLine(lista[i]);
            }

            for (int i = 0; i < contas.Tamanho; i++)
            {
                Console.WriteLine(contas[i]);
            }

            for (int i = 0; i < cursos.Tamanho; i++)
            {
                Console.WriteLine(cursos[i]);
            }

            Console.ReadLine();
        }

        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente(2);

            lista.AdicionarVarios(
                new ContaCorrente(1, 123),
                new ContaCorrente(1, 456),
                new ContaCorrente(1, 789),
                new ContaCorrente(2, 123),
                new ContaCorrente(2, 456)
            );
            ContaCorrente conta = lista[3];

            lista.Remover(conta);

            for (int i = 0; i < lista.Tamanho; i++)
            {
                Console.WriteLine(lista[i]);
            }
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
