


public class ContaCorrente
{
    public string titular;
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