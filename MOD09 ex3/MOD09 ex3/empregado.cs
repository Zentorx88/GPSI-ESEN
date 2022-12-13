using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD09_ex3
{
    class empregado
    {
        public string nome;
        public   int idade;

        public empregado(string _nome, int _idade)
        {
            nome = _nome;
            idade = _idade;
        }

        public void MostrarInformacao()
        {
            Console.WriteLine("{0}, {1} anos", nome, idade);
        }
    }
}
