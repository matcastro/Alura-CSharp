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
            Console.WriteLine(gerente.Autenticar("123"));
            Console.WriteLine(gerente.Autenticar("12"));

            Console.ReadLine();
        }
    }
}
