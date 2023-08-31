using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Model;
using Banco.view;

namespace Banco.Controller
{
    internal class ControllerConta
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        public static void controllerConta()
        {
            ModelConta mdConta = new ModelConta(0, 0, 0, null, 0);

            switch (MenuView.confirm)
            {
                case 1:
                    //Console.Write("Criar Conta: ");
                    mdConta.Visualizar();
                    Console.ResetColor();
                    KeyPress();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Listar Todas as Contas:\n\n");
                    Console.ResetColor();
                    KeyPress();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Digite o numero referente a sua conta: ");
                    Console.ResetColor();
                    KeyPress();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Digite o numero referente a sua conta: ");
                    Console.ResetColor();
                    KeyPress();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Apagar a sua conta: ");
                    Console.ResetColor();
                    KeyPress();
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Sacar o Dinheiro da sua conta: ");
                    Console.ResetColor();
                    KeyPress();
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Depositar o Dinheiro da sua conta: ");
                    Console.ResetColor();
                    KeyPress();
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Transferir o Dinheiro da sua conta: ");
                    Console.ResetColor();
                    KeyPress();
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(
                        "\n=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+++=+=+=+=+=+=+=+=+=+=+=" +
                        "\nBanco Suspeito - Para Sempre no Console de sua casa\n" +
                        "Cuidado com seu CMD\n");
                    Sobre();
                    Console.ResetColor();
                    System.Environment.Exit(0);
                    break;
                case 0:
                    mdConta.Visualizar();
                    Console.ResetColor();
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

        }

        static void KeyPress()
        {
            do
            {   
                Console.Write("\nPressione Enter para Continuar...");
                consoleKeyInfo = Console.ReadKey();
                Console.Clear();
                MenuView.MenuConsole();
            } while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }
    }
}
