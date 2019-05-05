using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bytebank.SistemaAgencia
{
    class Program
    {
        readonly static string padraoTelefone = "[0-9]{4,5}[- ]?[0-9]{4}";
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123, 12345);
            Console.WriteLine(conta);

            Cliente carlos = new Cliente();
            carlos.CPF = "123.456.789-10";
            carlos.Nome = "Carlos";
            carlos.Profissao = "Programador";

            Cliente carlos2 = new Cliente();
            carlos2.CPF = "123.456.789-10";
            carlos2.Nome = "Carlos";
            carlos2.Profissao = "Programador";

            Console.WriteLine(carlos.Equals(carlos2));

            Console.ReadLine();
        }

        static void TestaString()
        {
            string url = "pagina?moedaOrigem=real&moedaDestino=dolar&valor=1500";

            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);
            string moedaDestino = extrator.GetValor("MOEDADESTINO");
            string moedaOrigem = extrator.GetValor("moedaorigem");
            string valor = extrator.GetValor("vAlor");
            Console.WriteLine(moedaDestino);
            Console.WriteLine(moedaOrigem);
            Console.WriteLine(valor);
        }

        static void TestaRegex()
        {
            Console.WriteLine(RecuperarTelefoneDeTexto("Meu número é: 23423453"));
        }

        static string RecuperarTelefoneDeTexto(string texto)
        {
            Match telefone = Regex.Match(texto, padraoTelefone);
            return telefone.Value;
        }
    }
}
