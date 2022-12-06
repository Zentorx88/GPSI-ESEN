using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite 3 numeros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior: " + resultado);
        }
        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c && b > a)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;

        }
    }
}
