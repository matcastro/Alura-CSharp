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
            contaMateus.titular = new Cliente();
            contaMateus.titular.nome = "Nome Teste";
            contaMateus.titular.cpf = "12345678910";
            contaMateus.titular.profissao = "Pedreiro";
            contaMateus.numero = 1;
            contaMateus.Depositar(10);
            contaMateus.agencia = 1;

            Console.WriteLine(contaMateus.titular);
            Console.WriteLine(contaMateus.titular.nome);
            Console.WriteLine(contaMateus.titular.cpf);
            Console.WriteLine(contaMateus.titular.profissao);
            Console.WriteLine(contaMateus.agencia);
            Console.WriteLine(contaMateus.numero);
            Console.WriteLine(contaMateus.saldo);

            Console.ReadLine();
        }
    }
}
