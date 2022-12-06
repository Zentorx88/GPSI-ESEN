using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo_ex3
{
    class Produto
    {
        string nome;
        double preco;
        int quantidade;

        public string DevolveNome()
        {
            return nome;
        }

        public double DevolvePreco()
        {
            return preco;
        }

        public int DevolveQuantidade()
        {
            return quantidade;
        }
        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }


        public double ValorTotalEmStock()
        {
            return preco * quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            this.quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            this.quantidade -= quantidade;
        }

        public override string ToString()
        {
            return nome
            + ", $ "
            + preco.ToString("F2")
            + ", "
            + quantidade
            + " unidades, Total: $ "
            + ValorTotalEmStock().ToString("F2");

        }
    }
}
