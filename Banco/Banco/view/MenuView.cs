using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Banco.view
{
    internal class MenuView
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        public static void MenuConsole()
        {   
            int confirm = 0;

            bool parada = false;
            while (parada == false)
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
                    "\n|                                        |"+
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
                confirm = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (confirm)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Criar Conta: ");
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

        }

        static void KeyPress()
        {
            do
            {
                Console.Write("\nPressione Enter para Continuar...");
                consoleKeyInfo = Console.ReadKey();
            } while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }
    }
}
