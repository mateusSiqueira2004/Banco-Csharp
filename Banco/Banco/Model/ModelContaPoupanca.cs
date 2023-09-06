using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    public class ModelContaPoupanca : ModelConta
    {
        private int aniversario;

        public ModelContaPoupanca(int aniversario,int numero, int agencia, int tipo, string titular, decimal saldo) : 
            base(numero, agencia, tipo, titular, saldo)
        {
            this.aniversario = aniversario;
        }
        public int getAniversario()
        {
            return aniversario;
        }
        public void setAniversario(int aniversario)
        {
            this.aniversario = aniversario;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(
                $"\nSeu bonus de aniversario: {this.aniversario}" +
                "\n*************************************************\n");
        }
    }
}
