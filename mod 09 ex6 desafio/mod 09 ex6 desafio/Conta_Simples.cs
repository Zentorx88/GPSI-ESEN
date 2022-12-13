using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod_09_ex6_desafio
{
    public class Conta_Simples
    {
        //variaveis
        int nmr_conta;
        string titular;
        double saldo;
        string nmr_cartao;

        Cheque c1;

        public Conta_Simples(int nmr_conta, string titular, double saldo, string nmr_cartao, Cheque c1)
        {
            this.nmr_conta = nmr_conta;
            this.titular = titular;
            this.saldo = saldo;
            this.nmr_cartao = nmr_cartao;
            this.c1 = c1;
        }

        public void DevolveInfo()
        {
            Console.WriteLine("O numero da conta e: ");
            Console.WriteLine("O titular da conta e: ");
            Console.WriteLine("O saldo da conta e: ");
            Console.WriteLine("O");
        }
    }
}
