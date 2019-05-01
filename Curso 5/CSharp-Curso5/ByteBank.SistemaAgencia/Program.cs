using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;
using Humanizer.Localisation;
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
            DateTime dataPagamento = new DateTime(2019, 5, 2);
            DateTime dataCorrente = DateTime.Now;

            Console.WriteLine(dataPagamento);
            Console.WriteLine(dataCorrente);

            TimeSpan diferenca = dataPagamento - dataCorrente;

            Console.WriteLine("Diferença de " + TimeSpanHumanizeExtensions.Humanize(diferenca, maxUnit:TimeUnit.Year));

            Console.ReadLine();
        }
    }
}
