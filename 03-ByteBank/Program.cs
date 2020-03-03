using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 1615;
            contaDaGabriela.numero = 5677845;
            contaDaGabriela.saldo = 100;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 1615;
            contaDaGabrielaCosta.numero = 5677845;
            contaDaGabrielaCosta.saldo = 100;

            Console.WriteLine("Igualdade do tipo de referencia: " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 17;
            int idadeMaisUmaVez = 17;
            Console.WriteLine("Igualdade do tipo de valor: " + (idade == idadeMaisUmaVez));

            //Passagem do endereço da memoria para a outra variavel
            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine("Passando valor por referencia: " + (contaDaGabriela == contaDaGabrielaCosta));

            //Agora aqui ao mudar apenas o saldo no objeto contaDaGabriela eu tambem altero o mesmo valor na variavel contaDaGabrielaCosta
            //pois agora as duas variaveis tando a gabriela quanto a gabriela costa apontam para o mesmo objeto
            contaDaGabriela.saldo = 1500;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
