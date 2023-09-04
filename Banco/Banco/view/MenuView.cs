using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Banco.Model;
using Banco.Controller;

namespace Banco.view
{
    internal class MenuView
    {
        public static int confirm = 0;
        ModelContaCorrente c1 = new(1000,250,654,2,"Mateus",1000000);

        public static void MenuConsole()
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
                    "\n| 0-Visualizar Informações               |" +
                    "\n|                                        |" +
                    "\n******************************************");
                confirm = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                ControllerConta.controllerConta();
        }
    }
}
