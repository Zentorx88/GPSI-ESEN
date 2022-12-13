using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_polimorfismo
{
    class Patrao : Empregado
    {

        public Patrao(string nome) : base(nome)
        {

        }

        //metodo reescrito
        public override void MostrarFuncao()
        {
            Console.WriteLine("Patrão");  
        }
    }
}
