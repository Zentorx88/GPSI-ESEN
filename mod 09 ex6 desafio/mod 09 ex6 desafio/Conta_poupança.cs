using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod_09_ex6_desafio
{
    class Conta_poupança : Conta_Simples
    {
        string data;

        public Conta_poupança(int nmr_conta, string titular, double saldo, string nmr_cartao, Cheque c1, string data) : base(nmr_conta, titular, saldo, nmr_cartao, c1)
        {
            this.data = data;
        }

    }
}
