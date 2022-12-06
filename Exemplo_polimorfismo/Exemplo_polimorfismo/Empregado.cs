using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_polimorfismo
{
    class Empregado
    {
        //atributo da classe
        string nome;
        
        public Empregado()
        {

        }

        //construtor da classe em que recebe o nome(n)
        public Empregado(string n)
        {
            nome = n;
        }

        //função que mostra o nome do empregado 
        public void MostrarNome()
        {
            Console.WriteLine(nome);
        }

        //método virtual q pode ser reescrito na classe derivada
        public virtual void MostrarFuncao()
        {
            Console.WriteLine("Empregado");
        }
    }
}
