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
            Console.WriteLine(RecuperarTelefoneDeTexto("Meu número é: 23423453"));
            Console.ReadLine();

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar&valor=1500";

            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);
            string moedaDestino = extrator.GetValor("MOEDADESTINO");
            string moedaOrigem = extrator.GetValor("moedaorigem");
            string valor = extrator.GetValor("vAlor");
            Console.WriteLine(moedaDestino);
            Console.WriteLine(moedaOrigem);
            Console.WriteLine(valor);

            Console.ReadLine();
        }

        static string RecuperarTelefoneDeTexto(string texto)
        {
            Match telefone = Regex.Match(texto, padraoTelefone);
            return telefone.Value;
        }
    }
}
