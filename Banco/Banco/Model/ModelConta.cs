namespace Banco.Model
{
    public class ModelConta
    {
        private int numero, agencia, tipo;
        private string titular = string.Empty;
        private decimal saldo;

        public ModelConta(int numero, int agencia, int tipo, string titular, decimal saldo)
        {
            this.numero = numero;
            this.agencia = agencia;
            this.tipo = tipo;
            this.titular = titular;
            this.saldo = saldo;
        }
        public int getNumero() { 
            return numero;
        }
        public int getAgencia(){
            return agencia; 
        }
        public int getTipo(){
            return tipo; 
        }
        public string getTitular() {  
            return titular; 
        }
        public decimal getSaldo() {  
            return saldo; 
        }

        public void setSaldo(decimal saldo) { 
            this.saldo = saldo; 
        }
        public void setTitular(string titular) { 
            this.titular = titular; 
        }
        public void setTipo(int tipo) { 
            this.tipo = tipo; 
        }
        public void setAgencia(int agencia) { 
            this.agencia = agencia; 
        }
        public void setNumero(int numero) { 
            this.numero = numero; 
        }

        public virtual bool Sacar(decimal valor)
        {
            if (this.saldo < valor) {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            this.setSaldo(this.saldo - valor);
            return true;
        }
        public void Depositar(decimal valor)
        {
            this.setSaldo(this.saldo + valor);
        }

        public virtual void Visualizar()
        {
            string tipo = string.Empty;
            
            switch(this.tipo)
            {
                case 1:
                    tipo = "Conta Corrente";
                    break;
                case 2:
                    tipo = "Conta Poupança";
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(
                "\n*************************************************\n" +
                "\n     AQUI ESTÁ INFORMAÇÕES DA SUA CONTA\n" +
                "\n*************************************************\n" +
                $"\nSeu Numero de usuario: {this.numero}" +
                $"\nSua agência da sua conta: {this.agencia}" +
                $"\nSeu tipo de conta: {tipo}" +
                $"\nNome registrado na sua conta: {this.titular}" +
                $"\nSeu saldo: {this.saldo}");
        }
    }
}
