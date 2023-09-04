using Banco.Model;
using Banco.Repository;
using Banco.view;

namespace Banco.Controller
{
    public class ControllerConta
    {
        private static ConsoleKeyInfo consoleKeyInfo;
         public static void controllerConta()
        {
            ControllerRepository conta = new();

            switch (MenuView.confirm)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Cadastro de Conta");
                    ControllerCadastro.controllerCadastro();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Listar Todas as Contas:\n\n");
                    conta.ListarContas();
                    KeyPress();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Digite o numero referente a sua conta: ");
                    KeyPress();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Digite o numero referente a sua conta: ");
                    KeyPress();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Apagar a sua conta: ");
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
                MenuView.MenuConsole();
            } while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }

    }
}
