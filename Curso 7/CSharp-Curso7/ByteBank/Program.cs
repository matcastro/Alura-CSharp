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
            Console.ReadLine();
        }
    }
}
