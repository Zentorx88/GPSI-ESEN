using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composicao
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente c1 = new Cliente("João","jj@gmail.com");

            c1.DevolveMorada();

            Console.ReadKey();
        }
    }
}
