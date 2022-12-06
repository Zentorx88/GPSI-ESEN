using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M9_11H_N23
{
    class Pessoa
    {
        string nome, morada;
        int telefone;

        public string DevolverNome()
        {
            return nome;
        }

        public string DevolverMorada()
        {
            return morada;
        }

        public int DevolverTelefone()
        {
            return telefone;
        }

        public Pessoa()
        {

        }

        public Pessoa(string nome, string morada, int telefone)
        {
            this.nome = nome;
            this.morada = morada;
            this.telefone = telefone;
        }
    }
}
