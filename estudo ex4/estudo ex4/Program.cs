using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empregado> lista = new List<Empregado>();

            Console.WriteLine("Quantos funcionários sâo: ");
            int nmr_func = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nmr_func; i++)
            {
                Console.WriteLine($"Empregado {i}: ");
                Console.WriteLine("De fora da empresa? (s/n) ");
                string escolha = Console.ReadLine();
                if (escolha == "s" || escolha == "n")
                {
                    Console.WriteLine("Nome: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Horas: ");
                    int horas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Valor por horas: ");
                    double valorHora = double.Parse(Console.ReadLine());

                    if (escolha == "s")
                    {
                        Console.WriteLine("Taxa: ");
                        double taxa = double.Parse(Console.ReadLine());
                        lista.Add(new EmpregadoDeFora(nome, horas, valorHora, taxa));
                    }
                    else
                    {
                        lista.Add(new Empregado(nome, horas, valorHora));
                    }
                }

                else
                {
                    Console.WriteLine("Introduza s para sim ou n para nao");
                }

                Console.WriteLine();
                Console.WriteLine("Pagamentos: ");
                foreach (Empregado empregado in lista)
                {
                    Console.WriteLine(empregado.DevolverNome() + " - $ " + empregado.Pagamento().ToString("F2"));
                }
            }

        }
    }
}
