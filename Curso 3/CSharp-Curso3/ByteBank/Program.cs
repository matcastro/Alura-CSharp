using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Funcionario carlos = new Desenvolvedor("123.456.789-10");
            carlos.Nome = "Carlos";

            Diretor roberta = new Diretor("109.876.543-21");
            roberta.Nome = "Roberta";
            roberta.Senha = "111";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "000";

            SistemaInterno sistema = new SistemaInterno();
            sistema.Logar(parceiro, "000");
            sistema.Logar(roberta, "112");
            sistema.Logar(roberta, "111");

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);

            Console.WriteLine("Total de bonificações: R$ " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
