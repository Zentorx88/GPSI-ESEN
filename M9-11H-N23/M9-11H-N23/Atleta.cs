using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M9_11H_N23
{
    class Atleta : Pessoa
    {
        double peso, altura;

        public double DevolverPeso()
        {
            return peso;
        }

        public double DevolverAltura()
        {
            return altura;
        }

        public Atleta()
        {

        }

        public Atleta(string nome, string morada, int telefone, double peso, double altura) : base(nome, morada, telefone)
        {
            this.peso = peso;
            this.altura = altura;
        }

        public double CalcularIMC()
        {
            double imc = peso / (altura * altura);
            return Math.Round(imc, 2);
        }

        //public Classificar(double imc)
        //{
          //  string classificacao;
            //if (imc < 20)
            //{
              //  classificacao = "Magreza";
            //}
            //else if (imc >= 20 && imc <= 24.99)
            //{
              //  classificacao = "Normal";
          //  }
          //  else if (imc >= 25 && imc <= 29.99)
          //  {
            //    classificacao = "Excesso de peso";
         //   }
           // else if (imc >= 30 && imc <= 35)
            //{
   //             classificacao = "Obesidade";
     //       }
       //     else
         //   {
           //     classificacao = "Grande obesidade";
        //    }
          //  return classificacao;
       // }

    }
}
