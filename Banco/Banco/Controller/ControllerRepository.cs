using Banco.Model;
using Banco.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Controller
{
    public class ControllerRepository : IContaRepository
    {
        private readonly List<ModelConta> ListaConta = new();
        int numero = 0;

        public void Atualizar(ModelConta conta)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(ModelConta conta)
        {
            ListaConta.Add(conta);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                $"\n***************************************************\n" +
                $"\nA conta {conta.getNumero()} foi criada com sucesso!\n" +
                $"\n***************************************************\n");
            Console.ResetColor();
        }

        public void Deletar(int numero)
        {
            throw new NotImplementedException();
        }

        public void Depositar(int numero, decimal valor)
        {
            throw new NotImplementedException();
        }

        public void ListarContas()
        {
            foreach(var viewConta in ListaConta)
            {
                viewConta.Visualizar();
            }
        }

        public void ProcurarPorNumero(int numero)
        {
            throw new NotImplementedException();
        }

        public void Sacar(int numero, decimal valor)
        {
            throw new NotImplementedException();
        }

        public void Transferir(int numeroOrigem, int numeroDestino, decimal valor)
        {
            throw new NotImplementedException();
        }
        public int GerarNumero()
        {
            return ++numero;
        }
    }
}
