//using _05_ByteBank;

namespace _05_ByteBank
{
    public class ContaCorrente
    {
        //public _05_ByteBank.Cliente titular;
        public Cliente titular = new Cliente();
        public int agencia;
        public int numero;
        public double saldo = 100;

        //Esta função ira retornar um tipo boleano(true ou false)
        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            return true;

        }

        public void Depositar(double Valor)
        {
            this.saldo += Valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }


    }
}