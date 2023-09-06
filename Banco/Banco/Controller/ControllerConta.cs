using Banco.Model;
using Banco.Repository;
using Banco.view;
using System.ComponentModel;

namespace Banco.Controller
{
    public class ControllerConta
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        public static int numero = 0;

         public ControllerConta(ControllerRepository conta)
        {    
            switch (MenuView.confirm)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Cadastro de Conta");
                    new ControllerCadastro(conta);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    ModelContaCorrente cc1 = new ModelContaCorrente(conta.GerarNumero(), 12, 1, "Jovem", 1000, 100);
                    conta.Cadastrar(cc1);
                    Console.WriteLine("Listar Todas as Contas:\n\n");
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
                        new ControllerAtualizar(conta);
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"A conta {numero} não foi encontrada!");
                        Console.ResetColor();
                    }
                    KeyPress();
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
                    Console.Write("Sacar o Dinheiro da sua conta: ");
                    KeyPress();
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Depositar o Dinheiro na sua conta: ");
                    KeyPress();
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Transferir o Dinheiro da sua conta: ");
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
                new MenuView();
            } while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }
    }
}
