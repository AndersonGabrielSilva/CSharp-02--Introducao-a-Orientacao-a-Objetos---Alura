using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resultadoSaque;
            ContaCorrente contaAnderson = new ContaCorrente();

            Console.WriteLine("Saldo Anterior: " + contaAnderson.saldo);
            contaAnderson.titular = "Anderson";
            Console.WriteLine();

            resultadoSaque = contaAnderson.Sacar(500);  
                        
            //resultadoSaque = contaAnderson.Sacar(500);
            Console.WriteLine("Ocorreu o saque?: " + resultadoSaque);
            Console.WriteLine("Saldo: " + contaAnderson.saldo);

            contaAnderson.Depositar(500);
            Console.WriteLine("Saldo depois do Deposito: " + contaAnderson.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Conta do Anderson: " + contaAnderson.saldo);
            Console.WriteLine("Conta da Gabriela" + contaDaGabriela.saldo);

            bool resultadoTransferencia;
            resultadoTransferencia =  contaAnderson.Transferir(200, contaDaGabriela);
            Console.WriteLine();
            Console.WriteLine("Depois da Transferencia");
            Console.WriteLine("Resuldado da Transferencia: " + resultadoTransferencia);
            Console.WriteLine();
            Console.WriteLine("Conta do Anderson: " + contaAnderson.saldo);
            Console.WriteLine("Conta da Gabriela" + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
