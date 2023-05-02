﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDotNeT
{
    public class ContaBancaria
    {
        public double saldo;
        public string senha;
        public string nomeDoCliente;


        public double Sacar(double pValorSacado, string pSenha)
        {
            if (senha == pSenha)
            {
                if (saldo > pValorSacado)
                {
                    saldo -= pValorSacado;
                    Console.WriteLine("O valor sacado foi de: " + pValorSacado);
                    return pValorSacado;
                }
                else
                {
                    Console.WriteLine("O saldo é insuficiente ");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("A senha está incorreta");
                return 0;
            }
        }

        public void Depositar(double pValorDepositado)
        {
            saldo += pValorDepositado;
            Console.WriteLine("O valor depositado foi de: " + pValorDepositado);
        }

        public void ConsultaSaldo(string pSenha)
        {
            if (senha == pSenha)
            {
                Console.WriteLine("O saldo da conta é: " + saldo);

            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
    internal class Program
    {
        public static bool ReadKey { get; private set; }

        static void Main(string[] args)
        {
            ContaBancaria contaDoPedro = new ContaBancaria();
            contaDoPedro.saldo = 0;
            contaDoPedro.senha = "12345";
            contaDoPedro.nomeDoCliente = "Pedro Henrique";


            double valorSacado = contaDoPedro.Sacar(10, "12345");
            contaDoPedro.Depositar(1000);
            contaDoPedro.ConsultaSaldo("12345");
            valorSacado = contaDoPedro.Sacar(10, "12345");

            Console.ReadKey();
        }
    }
}
