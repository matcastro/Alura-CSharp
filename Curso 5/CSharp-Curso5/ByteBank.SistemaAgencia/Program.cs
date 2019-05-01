using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenteDeConta gerente = new GerenteDeConta("1235651");
            gerente.Senha = "123";

            ContaCorrente conta = new ContaCorrente(32, 55);
            conta.Sacar(20);
            Console.WriteLine(gerente.Autenticar("123"));
            Console.WriteLine(gerente.Autenticar("12"));

            Console.ReadLine();
        }
    }
}
