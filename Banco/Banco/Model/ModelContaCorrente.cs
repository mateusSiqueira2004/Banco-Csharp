﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    public class ModelContaCorrente:ModelConta
    {
        private decimal limite;

        public ModelContaCorrente(int numero, int agencia, int tipo, string titular, decimal saldo, decimal limite) 
            : base(numero, agencia, tipo, titular, saldo)
        {
            this.limite = limite;
        }
        public decimal getLimite()
        {
            return limite;
        }
        public void setLimite(decimal limite)
        {
            this.limite = limite;
        }
        public override bool Sacar(decimal valor)
        {
           if(this.getSaldo() + this.getLimite() < valor)
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            this.setSaldo(this.getSaldo() - valor);
            return true;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(
                $"\nSeu Limite de Crédito: {this.limite}" +
                "\n*************************************************\n");
        }
    }
}
