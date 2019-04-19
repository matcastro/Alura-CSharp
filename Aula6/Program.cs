using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                fatorial *= n;
                Console.WriteLine("O resultado de " + n + "! é " + fatorial);
            }

            Console.ReadLine();
        }
    }
}
