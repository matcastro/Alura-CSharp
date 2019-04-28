using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    class ContaCorrente
    {
        private double _saldo;
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public static int TotalDeContasCriadas { get; private set; }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
            }
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor || valor <= 0)
                return false;

            _saldo -= valor;
            return true;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            bool resultadoDoSaque = this.Sacar(valor);
            if (!resultadoDoSaque)
                return false;

            contaDestino.Depositar(valor);

            return true;
        }
    }
}
