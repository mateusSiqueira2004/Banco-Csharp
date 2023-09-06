using Banco.Model;
using Banco.Controller;

namespace Banco
{
    internal class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int confirm = 0, agencia = 0, tipo = 0, aniversario = 0, numero = 0, numeroDestino;
            string? titular = string.Empty;
            decimal saldo = 0, limite = 0, valor;
            ControllerRepository conta = new();
            ModelConta mdConta;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(
                    "\n ________________________________________" +
                    "\n|                                        |" +
                    "\n|               Bem Vindo                |" +
                    "\n|           Ao Banco Suspeito            |" +
                    "\n|           ¨¨ ¨¨¨¨¨ ¨¨¨¨¨¨¨¨            |" +
                    "\n|                                        |" +
                    "\n|________________________________________|");
                Console.ResetColor();
                Console.WriteLine(
                    "\n******************************************" +
                    "\n|                                        |" +
                    "\n|    O que você deseja para hoje?        |" +
                    "\n|                                        |" +
                    "\n| 1-Criar Conta                          |" +
                    "\n| 2-Listar todas as contas               |" +
                    "\n| 3-Buscar conta Por numero              |" +
                    "\n| 4-Atualizar dados da conta             |" +
                    "\n| 5-Apagar Conta                         |" +
                    "\n| 6-Sacar                                |" +
                    "\n| 7-Depositar                            |" +
                    "\n| 8-Transferir valores entre Contas      |" +
                    "\n| 9-Sair                                 |" +
                    "\n|                                        |" +
                    "\n******************************************");
                try
                {
                    confirm = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Insira valores validos");
                    confirm = 0;
                    KeyPress();
                }
                switch (confirm)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Cadastro de Conta");
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
                                KeyPress();
                                break;

                            case 2:
                                Console.WriteLine("\nDigite o Aniversario da sua conta: ");
                                aniversario = Convert.ToInt32(Console.ReadLine());
                                ModelContaPoupanca cp1 = new ModelContaPoupanca(aniversario, conta.GerarNumero(), agencia, tipo, titular, saldo);
                                conta.Cadastrar(cp1);
                                Console.Clear();
                                KeyPress();
                                break;
                        }
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Listar as Contas:\n\n");
                        conta.ListarContas();
                        KeyPress();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Digite o numero referente a sua conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                        conta.ProcurarPorNumero(numero);
                        KeyPress();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Digite o numero referente a sua conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                        if (conta.BuscarNaCollection(numero) is not null)
                        { 
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nDigite o Numero da Agencia: ");
                            agencia = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nDigite o nome do titular: ");
                            titular = Console.ReadLine();
                            titular ??= string.Empty;

                            Console.WriteLine("\nDigite o saldo da Conta: ");
                            saldo = Convert.ToDecimal(Console.ReadLine());

                            tipo = conta.RetonarTipo(numero);
                            switch (tipo)
                            {
                                case 1:
                                    Console.WriteLine("\nDigite o Limite da sua conta: ");
                                    limite = Convert.ToDecimal(Console.ReadLine());
                                    ModelContaCorrente cc1 = new ModelContaCorrente(numero, agencia, tipo, titular, saldo, limite);
                                    conta.Atualizar(cc1);
                                    KeyPress();
                                    break;

                                case 2:
                                    Console.WriteLine("\nDigite o Aniversario da sua conta: ");
                                    aniversario = Convert.ToInt32(Console.ReadLine());
                                    ModelContaPoupanca cp1 = new ModelContaPoupanca(aniversario, numero, agencia, tipo, titular, saldo);
                                    conta.Atualizar(cp1);
                                    KeyPress();
                                    break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"A conta {numero} não foi encontrada!");
                            Console.ResetColor();
                        }
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Apagar a sua conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                        conta.Deletar(numero);
                        KeyPress();
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Sacar o Dinheiro da sua conta\n");
                        Console.Write("Digite o numero da sua conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Digite o valor que deseja sacar: ");
                        valor = Convert.ToDecimal(Console.ReadLine());
                        conta.Sacar(numero, valor);

                        KeyPress();
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Depositar o Dinheiro da sua conta\n");
                        Console.Write("Digite o numero da sua conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Digite o valor que deseja depositar: ");
                        valor = Convert.ToDecimal(Console.ReadLine());
                        conta.Depositar(numero, valor);
                        KeyPress();
                        break;
                    case 8:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Transferir o Dinheiro da sua conta\n");
                        Console.Write("Digite o numero da sua conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Digite o numero da sua conta: ");
                        numeroDestino = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Digite o valor que deseja depositar: ");
                        valor = Convert.ToDecimal(Console.ReadLine());
                        conta.Transferir(numero,numeroDestino, valor);
                        KeyPress();
                        break;
                    case 9:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(
                            "\n=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+++=+=+=+=+=+=+=+=+=+=+=" +
                            "\nBanco Suspeito - Para Sempre no Console de sua casa\n" +
                            "Cuidado com seu CMD\n");
                        Sobre();
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Valor invalido!");
                        KeyPress();
                        break;
                }
            }
        }
        static void Sobre()
        {
            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("Projeto Desenvolvido por: ");
            Console.WriteLine("Mateus Siqueira - mateussiqueirasalomao@gmail.com");
            Console.WriteLine("github.com/mateusSiqueira2004");
            Console.WriteLine("*********************************************************");
            Console.ResetColor();
        }
        public static void KeyPress()
        {
            do
            {
                Console.Write("\nPressione Enter para Continuar...");
                consoleKeyInfo = Console.ReadKey();
                Console.ResetColor();
                Console.Clear();
            } while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }
    }
}