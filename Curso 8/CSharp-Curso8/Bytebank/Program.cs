using Bytebank.Extensoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(213,543),
                new ContaCorrente(147,245),
                new ContaCorrente(3,1000)
            };

            contas.Sort();

            foreach (var conta in contas)
            {
                Console.WriteLine(conta);
            }

            contas.Sort(new ComparadorContaCorrentePorAgencia());

            foreach (var conta in contas)
            {
                Console.WriteLine(conta);
            }

            Console.ReadLine();
        }
        
        static void TestaSort()
        {
            var idades = new List<int>();

            idades.AdicionarVarios(16, 63, 52, 94);
            idades.Remove(94);
            idades.Sort();

            var nomes = new List<string>()
            {
                "Kaká",
                "Ronaldinho",
                "Adriano"
            };
            nomes.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
