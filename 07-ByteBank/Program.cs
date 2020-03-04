using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total de Ccontas criadas: " + ContaCorrente.TotalDeContasCriadas);
            ContaCorrente conta = new ContaCorrente(863,59784);
            
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
            Console.WriteLine("Total de Ccontas criadas: " + ContaCorrente.TotalDeContasCriadas);

            ContaCorrente anderson = new ContaCorrente(148, 56842);
            Console.WriteLine( "Total de Ccontas criadas: " + ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
