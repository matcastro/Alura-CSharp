using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaMateus = new ContaCorrente();
            Console.WriteLine(contaMateus.saldo);

            contaMateus.Depositar(200);
            Console.WriteLine(contaMateus.saldo);

            contaMateus.Sacar(50);
            Console.WriteLine(contaMateus.saldo);

            ContaCorrente contaTati = new ContaCorrente();
            Console.WriteLine(contaTati.saldo);
            contaMateus.Transferir(100, contaTati);
            Console.WriteLine(contaMateus.saldo);
            Console.WriteLine(contaTati.saldo);

            contaMateus.Depositar(-200);
            Console.WriteLine(contaMateus.saldo);

            contaMateus.Sacar(5000);
            Console.WriteLine(contaMateus.saldo);

            contaMateus.Sacar(-50);
            Console.WriteLine(contaMateus.saldo);

            contaMateus.Transferir(1000, contaTati);
            Console.WriteLine(contaMateus.saldo);

            contaMateus.Transferir(-100, contaTati);
            Console.WriteLine(contaMateus.saldo);
            Console.ReadLine();
        }
    }
}
