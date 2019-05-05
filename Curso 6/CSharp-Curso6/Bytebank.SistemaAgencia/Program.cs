using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
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
    }
}
