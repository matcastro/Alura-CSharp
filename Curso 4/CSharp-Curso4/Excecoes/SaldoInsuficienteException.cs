using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }

        public SaldoInsuficienteException(double saldo, double valorSaque) : this("Saldo " + saldo + " insuficiente para o saque no valor de " + valorSaque + "!")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
    }
}
