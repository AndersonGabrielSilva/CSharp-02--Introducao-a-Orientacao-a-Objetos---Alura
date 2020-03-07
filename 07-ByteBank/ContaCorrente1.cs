//using _05_ByteBank;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        //public _05_ByteBank.Cliente titular;

        private int _agencia;
        private int _numero;
        private int _totalDeContasCriadas;
        public Cliente Titular { get; set; }/**/

        /*Ultilizamos Static para informar que esta caracteristica é da classe e não do Objeto que será instanciado
          Aqui no exemplo abaixo o metodo só é publico quando for acessar o get porem ele privado quando for acessar o set
          ou seja desta forma se torna impossivel alguma ação exterior mudar o valor interno este metodo*/
        public static int TotalDeContasCriadas{get;private set;}

        public int Agencia { get; set; }
        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                if (value<=0)
                {
                    return;
                }

                _numero = value;
            }
        }
        private double _saldo = 100;


        public double Saldo
        {
            //Ultilizamos o Get para um metodo que retorna uma caracteristica do Objeto
            get
            {
                return _saldo;
            }
            //Ultilizamos o Set para um metodo que vamos mudar algo do Objeto
            set//Ultilizamos o Set para um metodo que vamos mudar algo do Objeto
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;// o "value" seria o valor que será informado
            }
        }

        /*Um construtor é a forma que eu quero contruir o objeto neste caso eu 
        obrigo que algum dado seja inserido na inicialização do objeto ou seja 
        o numero da agencia e da conta NUNCA será 0 */
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            //Sempre que este construtor é inicializado ele ira adicionar mais 1
            TotalDeContasCriadas++;
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