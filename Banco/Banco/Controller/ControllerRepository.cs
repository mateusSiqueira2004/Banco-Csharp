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
        private readonly List<ModelConta> listaContas = new();

        int numero = 0;

        public void Atualizar(ModelConta conta)
        {
            var buscarConta = BuscarNaCollection(conta.getNumero());
            if(buscarConta != null ) {              
                var indexOf = listaContas.IndexOf(buscarConta);
                listaContas[indexOf] = conta;
                Console.WriteLine($"A conta {conta.getNumero()} foi atualizada com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A conta {numero} não foi encontrada!");
                Console.ResetColor();
            }
        }

        public void Cadastrar(ModelConta conta)
        {
            listaContas.Add(conta);
           /* Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                $"\n***************************************************\n" +
                $"\nA conta {conta.getNumero()} foi criada com sucesso!\n" +
                $"\n***************************************************\n");
            Console.ResetColor();*/
        }

        public void Deletar(int numero)
        {
            var conta = BuscarNaCollection(numero);
            if (conta is not null)
            {
                if (listaContas.Remove(conta) == true)
                    Console.WriteLine($"A conta {numero} foi apagada com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A conta {numero} não foi encontrada!");
                Console.ResetColor();
            }
        }

        public void Depositar(int numero, decimal valor)
        {
            throw new NotImplementedException();
        }

        public void ListarContas()
        {
            foreach (var contas in listaContas)
            {
                contas.Visualizar();
            }
        }

        public void ProcurarPorNumero(int numero)
        {
            var conta = BuscarNaCollection(numero);
            if (conta is not null)
                conta.Visualizar();
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine($"A conta {numero} não foi encontrada!");
                Console.ResetColor();
            }
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

        public ModelConta? BuscarNaCollection(int numero)
        {
            foreach (var conta in listaContas) 
            { 
                if(conta.getNumero() == numero)
                {
                    return conta;
                }
            }
            return null;
        }
        public int RetonarTipo(int numero)
        {
            foreach(var conta in listaContas)
            {
                if(conta.getNumero() == numero)
                {
                    return conta.getTipo();
                }
            }
            return 0;
        }
    }
}
