using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo_ex4
{
    class EmpregadoDeFora : Empregado
    {
        double taxa;
        
        public double DevolverTaxa()
        {
            return taxa;
        }

        public EmpregadoDeFora(string nome, int horas, double valorHora, double taxa) : base(nome, horas, valorHora)
        {
            this.taxa = taxa;
        }

        public double PagamentoFuncionarioFora()
        {
            return base.Pagamento() + 1.1 * taxa;    
        }
    }
}
