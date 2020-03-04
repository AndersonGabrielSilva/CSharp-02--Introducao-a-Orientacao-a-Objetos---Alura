using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            conta.Titular = cliente;

            conta.Titular.Nome = "Anderson";
            conta.Titular.CPF = "428.137.298-94";
            conta.Titular.Profissao = "Estagiario";
            conta.Saldo = -100;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();

        }
    }
}
