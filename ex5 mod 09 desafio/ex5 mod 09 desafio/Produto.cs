using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_mod_09_desafio
{
    class Produto
    {
        //variaveis
        string nome;
        double precoCusto;
        double precoVenda;
        double margemLucro;

        //retornar o conteudo da variavel (encapsulamento)
        public string retornarNome()
        {
            return nome;
        }

        public double retornarPrecoCusto()
        {
            return precoCusto;
        }

        public double retornarPrecoVenda()
        {
            return precoVenda;
        }
        
        public double retornarMargemLucro()
        {
            return margemLucro;
        }

        //alterar o valor da variavel (encapsulamento para alterar valor)
        public void alteraNome(string nome)
        {
            this.nome = nome;
        }

        public void alteraPrecoCusto(double precoCusto)
        {
            this.precoCusto = precoCusto;   
        }

        public void alteraPrecoVenda(double precoVenda)
        {
            this.precoVenda = precoVenda;
        }

        public void alteraMargemLucro(double margemLucro)
        {
            this.margemLucro = margemLucro;
        }

        //calculo da margem de lucro (método com retorno)
        public double calcularMargemLucro()
        {
            if (precoVenda < precoCusto)
            {
                Console.WriteLine("Boas amigo, és burro visto que nao vais ter lucro!");
                margemLucro = 0;
            }
            else
            {
                margemLucro = precoVenda - precoCusto;
            }
            return margemLucro;
        }

        //calcular a porcentagem do lucro com 1 casa decimal (metodo com retorno)
        public double getMargemLucroPorcentagem()
        {
            double margemLucroPorcentagem = (margemLucro * 100) / precoCusto;
            return Math.Round(margemLucroPorcentagem, 1);
        }


        //bob construtor de objetos da classe produto
        public Produto(double precoVendas, double precoCustos)
        {
            precoCusto = precoCustos;
            precoVenda = precoVendas;
        }
        

    }

}
