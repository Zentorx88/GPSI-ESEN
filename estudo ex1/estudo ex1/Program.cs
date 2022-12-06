using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço do produto: ");
            double produto = double.Parse(Console.ReadLine());
            Console.WriteLine("Ultimo nome, idade e altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimo_nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(produto.ToString("F2"));
            Console.WriteLine(ultimo_nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"));
        }
    }
}
