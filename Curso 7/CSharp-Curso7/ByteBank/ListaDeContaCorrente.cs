using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;

        public ListaDeContaCorrente(int capacidadeInicial = 5)
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void Adicionar(ContaCorrente item)
        {
            VerificarCapacidade(_proximaPosicao + 1);
            //Console.WriteLine($"Adicionando no índice {_proximaPosicao} conta {item.Agencia}/{item.Numero}");

            if (_proximaPosicao <= _itens.Length)
            {
                _itens[_proximaPosicao] = item;
                _proximaPosicao++;
            }
        }

        public void Remover(ContaCorrente item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                if (item.Equals(_itens[i]))
                {
                    indiceItem = i;
                    break;
                }
            }
            if (indiceItem > -1)
            {
                for (int i = indiceItem; i < _proximaPosicao-1; i++)
                {
                    _itens[i] = _itens[i + 1];
                }

                _proximaPosicao--;
                _itens[_proximaPosicao] = null;
            }

        }

        public void imprimeLista()
        {
            Console.WriteLine();
            for (int i = 0; i < _proximaPosicao; i++)
            {
                Console.WriteLine($"{_itens[i]}");
            }
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
            }
            _itens = novoArray;

            Console.WriteLine("Aumentando capacidade da lista!");

        }
    }
}
