﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                conta1.Transferir(10000, conta2);
                //conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }
            //try
            //{
            //    ContaCorrente conta = new ContaCorrente(1, 254162);
            //    conta.Depositar(100);
            //    conta.Sacar(50);
            //    //conta.Sacar(500);
            //    conta.Sacar(-50);
            //}
            //catch(ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.ParamName);
            //}
            //catch(SaldoInsuficienteException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //try
            //{
            //    Metodo();
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("Não é possível divisão por 0!");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.StackTrace);
            //}
            Console.ReadLine();
        }

        static void Metodo()
        {
            TestaDivisao(0);
        }

        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }

        public static int Dividir(int numero, int divisor)
        {
            //ContaCorrente conta = null;
            //Console.WriteLine(conta.Saldo);
            try
            {
                return numero / divisor;
            }
            catch (Exception)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                throw;
            }
        }
    }
}
