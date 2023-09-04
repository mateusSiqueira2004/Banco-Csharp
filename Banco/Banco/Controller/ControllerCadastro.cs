using System;
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
        public static void controllerCadastro()
        {
            int agencia, tipo, aniversario;
            string? titular;
            decimal saldo, limite;

            ControllerRepository conta = new();

            Console.WriteLine("\nDigite o Numero da Agencia: ");
            agencia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o nome do titular: ");
            titular = Console.ReadLine();
            titular ??= string.Empty;
            do
            {
                Console.WriteLine("\nDigite o tipo da Conta: ");
                tipo = Convert.ToInt32(Console.ReadLine());
            } while (tipo != 1 && tipo != 2);

            Console.WriteLine("\nDigite o saldo da Conta: ");
            saldo = Convert.ToDecimal(Console.ReadLine());

            switch (tipo)
            {
                case 1:
                    Console.WriteLine("\nDigite o Limite da sua conta: ");
                    limite = Convert.ToDecimal(Console.ReadLine());
                    conta.Cadastrar(new ModelContaCorrente(conta.GerarNumero(), agencia, tipo, titular, saldo, limite));
                    ControllerConta.KeyPress();
                    break;
                case 2:
                    Console.WriteLine("\nDigite o Aniversario da sua conta: ");
                    aniversario = Convert.ToInt32(Console.ReadLine());
                    conta.Cadastrar(new ModelContaPoupanca(aniversario, conta.GerarNumero(), agencia, tipo, titular, saldo));
                    ControllerConta.KeyPress();
                    break;
            }
        }
    }
}
