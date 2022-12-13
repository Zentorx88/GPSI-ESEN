using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_mod_09_desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            double custo;
            double venda;


            Console.WriteLine("Qual o custo do produto");
            custo = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preco da venda do produto");
            venda = double.Parse(Console.ReadLine());

            Produto p1 = new Produto(venda, custo);

            Console.WriteLine("Preco de custo: " + p1.retornarPrecoCusto());
            Console.WriteLine("Preco de venda: " + p1.retornarPrecoVenda());
            Console.WriteLine("Margem de lucro: " + p1.calcularMargemLucro());
            Console.WriteLine("Porcentagem da margem de lucro: " + p1.getMargemLucroPorcentagem());
            
        }
    }
}
