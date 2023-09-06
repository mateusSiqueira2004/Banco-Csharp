﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Banco.Model;
using Banco.view;

namespace Banco.Controller
{
    public class ControllerCadastro
    {
        public ControllerCadastro(ControllerRepository conta)
        {
            int agencia = 0, tipo = 0, aniversario = 0;
            string? titular = string.Empty;
            decimal saldo = 0, limite = 0;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDigite o Numero da Agencia: ");
            agencia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o nome do titular: ");
            titular = Console.ReadLine();
            titular ??= string.Empty;

            do
            {
                Console.WriteLine("\nDigite o tipo da Conta (1 para conta Conrrente e 2 para conta Poupança): ");
                tipo = Convert.ToInt32(Console.ReadLine());
            } while (tipo != 1 && tipo != 2);

            Console.WriteLine("\nDigite o saldo da Conta: ");
            saldo = Convert.ToDecimal(Console.ReadLine());

            switch (tipo)
            {
                case 1:
                    Console.WriteLine("\nDigite o Limite da sua conta: ");
                    limite = Convert.ToDecimal(Console.ReadLine());
                    ModelContaCorrente cc1 = new ModelContaCorrente(conta.GerarNumero(), agencia, tipo, titular, saldo, limite);
                    conta.Cadastrar(cc1);
                    Console.Clear();
                    ControllerConta.KeyPress();
                    break;

                case 2:
                    Console.WriteLine("\nDigite o Aniversario da sua conta: ");
                    aniversario = Convert.ToInt32(Console.ReadLine());
                    ModelContaPoupanca cp1 = new ModelContaPoupanca(aniversario, conta.GerarNumero(), agencia, tipo, titular, saldo);
                    conta.Cadastrar(cp1);
                    Console.Clear();
                    ControllerConta.KeyPress();
                    break;
            }
        }
    }
}
