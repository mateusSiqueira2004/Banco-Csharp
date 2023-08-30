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
                    "\n| 1-Acessar Conta                        |" +
                    "\n| 2-Listar todas as contas               |" +
                    "\n| 3-Criar Conta                          |" +
                    "\n| 4-Sair do Programa                     |" +
                    "\n|                                        |" +
                    "\n******************************************");
                confirm = Convert.ToInt32(Console.ReadLine());
                
    
            }
        }
    }
}
