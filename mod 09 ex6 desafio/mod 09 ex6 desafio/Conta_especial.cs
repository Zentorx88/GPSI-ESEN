using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod_09_ex6_desafio
{
    public class Conta_especial : Conta_Simples
    {
        double limite, taxa;


        public Conta_especial(int nmr_conta, string titular, double saldo, string nmr_cartao, Cheque c1, double limite, double taxa ) : base(nmr_conta, titular, saldo, nmr_cartao, c1)
        {
            this.limite = limite;
            this.taxa = taxa;
        }
    }
}
