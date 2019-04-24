using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class ContaCorrente
    {
        public string titular;
        public int agencia;
        public int numero;
        public double saldo;

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
            }
        }

        public bool Sacar(double valor)
        {
            if (this.saldo < valor || valor <= 0)
                return false;

            this.saldo -= valor;
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
