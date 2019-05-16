using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank
{
    public class ContaCorrente : IComparable
    {
        private static int TaxaOperacao;

        public static int TotalDeContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public int Numero { get; }
        public int Agencia { get; }

        private double _saldo = 100;
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

        /// <summary>
        /// Cria uma instância de <see cref="ContaCorrente"/> com os argumentos utilizados.
        /// </summary>
        /// <param name="agencia">Representa o valor da propriedade <see cref="Agencia"/> e deve ser maior que zero.</param>
        /// <param name="numero">Representa o valor da propriedade <see cref="Numero"/> e deve ser maior que zero.</param>
        public ContaCorrente(int agencia, int numero)
        {
            if (numero <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>
        /// </summary>
        /// <exception cref="ArgumentException">Exceção lançada quando o parâmetro <paramref name="valor"/> for menor que zero.</exception>
        /// <exception cref="SaldoInsuficienteException">Exceção lançada quando o parâmetro <paramref name="valor"/> for menor que a propriedade <see cref="Saldo"/></exception>
        /// <param name="valor">Representa o valor do saque e deve ser maior que zero e menor que a propriedade <see cref="Saldo"/>.</param>
        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }

            contaDestino.Depositar(valor);
        }

        public override string ToString()
        {
            return $"Agência {Agencia}, Número {Numero}, Saldo {Saldo}";
        }

        public override bool Equals(object obj)
        {
            ContaCorrente conta = obj as ContaCorrente;

            if (conta == null)
                return false;

            return conta.Agencia == Agencia && conta.Numero == Numero;
        }

        public int CompareTo(object obj)
        {
            var conta = obj as ContaCorrente;
            if (conta == null)
                return -1;
            if (Numero < conta.Numero)
                return -1;
            if (Numero == conta.Numero)
                return 0;
            return 1;
        }
    }
}
