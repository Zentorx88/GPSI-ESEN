using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo_ex4
{
    class Empregado
    {
        string nome;
        int horas;
        double valorHora;

        public string DevolverNome()
        {
            return nome;
        }

        public int DevolverHoras()
        {
            return horas;
        }

        public double DevolverValorHora()
        {
            return valorHora;
        }

        public Empregado(string nome, int horas, double valorHora)
        {
            this.nome = nome;
            this.horas = horas;
            this.valorHora = valorHora;
        }

        public double Pagamento()
        {
            return horas * valorHora;
        }
    }
}
