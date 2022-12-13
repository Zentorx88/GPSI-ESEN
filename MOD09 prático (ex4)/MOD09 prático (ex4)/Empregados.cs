using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD09_prático__ex4_
{
    class Empregados
    {
        //criaçao das variaveis privadas (protegidas)
        private double saldo;
        private string nome_e;


        //criação de variaveis na funçao
        public Empregados(string _nome_e, double _saldo)
        {
            saldo = _saldo;
            nome_e = _nome_e;
        }


        //passagem da variavel saldo para a outra classe (program.cs)
        public double MostrarSaldo()
        {
            return saldo;
        }

        //passagem da variavel nome para a outra classe (program.cs)
        public string MostrarNome()
        {
            return nome_e;
        }

    }   
}
