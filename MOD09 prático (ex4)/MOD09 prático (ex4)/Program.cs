using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD09_prático__ex4_
{
    class Program
    {
        static void Main(string[] args)
        {
            //registo dos empregados (feito manualmente sem qualquer introduçao por parte do usuario)
            Empregados e1 = new Empregados("Tiago", 1000);
            Empregados e2 = new Empregados("Miguel", 900);
            Empregados e3 = new Empregados("Martim", 950);
            Empregados e4 = new Empregados("Rafael", 900);
            Empregados e5 = new Empregados("António", 800);


            //calculo da media de saldo da empresa
            double media = (e1.MostrarSaldo() + e2.MostrarSaldo() + e3.MostrarSaldo() + e4.MostrarSaldo() + e5.MostrarSaldo()) / 5;
            
            


            //dicionario dos empregados e salarios
            Dictionary<string, double> empre_sal = new Dictionary<string, double>();
            empre_sal.Add(e1.MostrarNome(), e1.MostrarSaldo());
            empre_sal.Add(e2.MostrarNome(), e2.MostrarSaldo());
            empre_sal.Add(e3.MostrarNome(), e3.MostrarSaldo());
            empre_sal.Add(e4.MostrarNome(), e4.MostrarSaldo());
            empre_sal.Add(e5.MostrarNome(), e5.MostrarSaldo());

            var maxvalor = empre_sal.OrderByDescending(x => x.Value).First().Key;
            Console.WriteLine("O empresário com maior salário é o/a "+ maxvalor+ " e a média de salários é " +media);
            Console.ReadLine();

        }
    }
}
