using Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Controller
{
    public class ControllerAtualizar
    {
        public ControllerAtualizar(ControllerRepository conta) 
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

            Console.WriteLine("\nDigite o saldo da Conta: ");
            saldo = Convert.ToDecimal(Console.ReadLine());

            tipo = conta.RetonarTipo(ControllerConta.numero);
            switch (tipo)
            {
                case 1:
                    Console.WriteLine("\nDigite o Limite da sua conta: ");
                    limite = Convert.ToDecimal(Console.ReadLine());
                    ModelContaCorrente cc1 = new ModelContaCorrente(conta.GerarNumero(), agencia, tipo, titular, saldo, limite);
                    conta.Atualizar(cc1);
                    Console.Clear();
                    ControllerConta.KeyPress();
                    break;

                case 2:
                    Console.WriteLine("\nDigite o Aniversario da sua conta: ");
                    aniversario = Convert.ToInt32(Console.ReadLine());
                    ModelContaPoupanca cp1 = new ModelContaPoupanca(aniversario, conta.GerarNumero(), agencia, tipo, titular, saldo);
                    conta.Atualizar(cp1);
                    Console.Clear();
                    ControllerConta.KeyPress();
                    break;
            }
        }
    }
}
