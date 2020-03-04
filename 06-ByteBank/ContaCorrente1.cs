//using _05_ByteBank;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        //public _05_ByteBank.Cliente titular;

        //
        public Cliente Titular { get; set; }/**/
        public int Agencia { get; set; }
        public int Numero  {get;set;}
        private double _saldo = 100;

       
        public double Saldo
        {
            //Ultilizamos o Get para um metodo que retorna uma caracteristica do Objeto
            get
            {
                return _saldo;
            }
            //Ultilizamos o Set para um metodo que vamos mudar algo do Objeto
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;// o "value" seria o valor que será informado
            }
        }               

        //Esta função ira retornar um tipo boleano(true ou false)
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            return true;

        }

        public void Depositar(double Valor)
        {
            this._saldo += Valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }

        /*
      //Ultilizamos o Get para um metodo que retorna uma caracteristica do Objeto
      public double GetSaldo()
      {

          return saldo;
      }

      // Ultilizamos o Set para um metodo que vamos mudar algo do Objeto
      public void SetSaldo(double saldo)
      {
          if (saldo < 0)
          {
              return;
          }

          this.saldo = saldo;


      }
      */

        /*
        private Cliente _titular;

        public Cliente Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                //_titular = new Cliente();
                _titular = value;
            }
        }
        */


    }
}