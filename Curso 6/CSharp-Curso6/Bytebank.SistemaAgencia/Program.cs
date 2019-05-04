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
            string url = "pagina?argumentos";
            Console.WriteLine(url);
            url = url.Substring(url.IndexOf("?") + 1);
            Console.WriteLine(url);
            Console.ReadLine();
        }
    }
}
