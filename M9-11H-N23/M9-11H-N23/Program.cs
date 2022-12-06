using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M9_11H_N23
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoaLista = new List<Pessoa>();

            Console.WriteLine("Quantas pessoas são? ");
            int nmr_pessoas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nmr_pessoas; i++)
            {
                Console.WriteLine($"Pessoa {i}: ");
                Console.WriteLine("É atleta? (s para sim, n para nao) ");
                string escolha = Console.ReadLine();

                if (escolha == "s" || escolha == "n")
                {
                    Console.WriteLine("Nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Morada: ");
                    string morada = Console.ReadLine();

                    Console.WriteLine("Telefone: ");
                    int telefone = int.Parse(Console.ReadLine());

                    if (escolha == "s")
                    {
                        Console.WriteLine("Peso: ");
                        double peso = double.Parse(Console.ReadLine());

                        Console.WriteLine("Altura: ");
                        double altura = double.Parse(Console.ReadLine());

                        pessoaLista.Add(new Atleta(nome, morada, telefone, peso, altura));
                    }
                    else
                    {
                        pessoaLista.Add(new Pessoa(nome, morada, telefone));
                    }
                }
                else
                {
                    Console.WriteLine("Introduza s para sim ou n para nao, caso contrário o programa não funcionará");
                }

                Console.WriteLine("Pessoas: ");
                foreach (Atleta pessoa in pessoaLista)
                {
                    Console.WriteLine("Nome: " + pessoa.DevolverNome() +" Morada: " + pessoa.DevolverMorada() + " Telefone: " + pessoa.DevolverTelefone() + " IMC: " +pessoa.CalcularIMC());
                    Console.WriteLine();
                }
            }


        }
    }
}
