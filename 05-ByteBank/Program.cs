using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
           // Cliente gabriela = new Cliente();
          //  gabriela.nome = "Gabriela";
           // gabriela.profissao = "Desenvolvedora de Software";
           // gabriela.cpf = "428.137.297-81";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabriela;

            //Estou atribuindo aqui uma nova instancia para a variavel titular
            //conta.titular = new Cliente();
            //conta.titular.nome = "Anderson gabriel";
           // conta.titular.cpf = "42813729893";
           // conta.titular.profissao = "Estagiario de Software";

            conta.saldo = 500;
            conta.agencia = 1632;
            conta.numero = 1015687;



            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);
            Console.WriteLine(conta.saldo);
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.numero);

            Console.ReadLine();
        }
    }
}
