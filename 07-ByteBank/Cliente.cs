using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class Cliente
    {
        /*
        public string Nome { get; set; }
        public string CPF {get;set;}
        public string Profissao { get; set; }
        */

        // Normalmente se ultiza por convenção no codigo para futuramente ser possivel uma facil manutencao

        // OU PODEMOS FAZER DA SEGUINTE FORMA   
        // Ultilizando o "prop" o codigo do função get e set já é formado automaticamente
        //prop + Tab -> Tab
        // public int MyProperty { get; set; }

            private string _cpf;
        public string Nome { get; set; }
        public string CPF 
        {
            get
            {
                return _cpf;
            }
            set
            {
                // Escrevo minha ligica de validação de CPF
                _cpf = value;
            }
                
        }
        public string Profissao { get; set; }

    }
}
