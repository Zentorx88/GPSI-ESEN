using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composicao
{
    class Cliente
    {
        string nome;
        string email;

        //Relação de composição o Cliente possui uma morada
        Morada m1 = new Morada("Rua x","2","Viseu","3500-009");


        public Cliente()
        {
           
        }


        public Cliente(string n, string e)
        {
            nome = n;
            email = e;
        }

        public string DevolveNome()
        {
            return nome;
        }

        public string DevolveEmail()
        {
            return email;
        }



        public void DevolveMorada()
        {
            Console.WriteLine(m1.DevolveRua());
            Console.WriteLine(m1.DevolveLocalidade());
        }


        public void AlteraNome(string n)
        {
            nome=n;
        }

        public void AlteraEmail(string e)
        {
            email=e;
        }


    }
}
