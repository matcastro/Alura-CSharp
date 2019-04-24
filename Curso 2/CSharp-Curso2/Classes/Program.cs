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
            contaMateus.Titular = new Cliente();
            contaMateus.Titular.Nome = "Nome Teste";
            contaMateus.Titular.CPF = "12345678910";
            contaMateus.Titular.Profissao = "Pedreiro";
            contaMateus.Numero = 1;
            contaMateus.Depositar(10);
            contaMateus.Agencia = 1;

            Console.WriteLine(contaMateus.Titular);
            Console.WriteLine(contaMateus.Titular.Nome);
            Console.WriteLine(contaMateus.Titular.CPF);
            Console.WriteLine(contaMateus.Titular.Profissao);
            Console.WriteLine(contaMateus.Agencia);
            Console.WriteLine(contaMateus.Numero);
            Console.WriteLine(contaMateus.Saldo);

            contaMateus.Sacar(10);
            Console.WriteLine(contaMateus.Saldo);
            Console.ReadLine();
        }
    }
}
