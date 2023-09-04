using Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Repository
{
    internal interface IContaRepository
    {
        public void ProcurarPorNumero(int numero);
        public void ListarContas();
        public void Cadastrar(ModelConta conta);
        public void Atualizar(ModelConta conta);
        public void Deletar(int numero);

        public void Sacar(int numero, decimal valor);
        public void Depositar(int numero, decimal valor);
        public void Transferir(int numeroOrigem, int numeroDestino, decimal valor);
    }
}
