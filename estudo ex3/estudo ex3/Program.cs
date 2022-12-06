using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados do produto: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade em stock: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a adicionar: ");
            int nmr_add = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(nmr_add);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a remover: ");
            int nmr_remover = int.Parse(Console.ReadLine());
            p.RemoverProdutos(nmr_remover);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados " + p);




        }
    }
}
