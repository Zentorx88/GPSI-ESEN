using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composicao
{
    class Morada
    {
        string rua;
        string numero;
        string localidade;
        string codigo_postal;


        public Morada()
        {
            rua="Sem rua atribuida";
            numero="sem número atribuido";
            localidade="";
            codigo_postal="0000-000";
        }



        public Morada(string r, string n, string l, string cp)
        {
            rua = r;
            numero = n;
            localidade = l;
            codigo_postal = cp;
        }

        public string DevolveRua()
        {
            return rua;
        }

        public string DevolveNumero()
        {
            return numero;
        }

        public string DevolveLocalidade()
        {
            return localidade;
        }

        public string DevolveCodigo_Postal()
        {
            return codigo_postal;
        }

        public void AlteraRua(string r)
        {
            rua=r;
        }

        public void AlteraNumero(string n)
        {
           numero=n;
        }

        public void AlteraLocalidade(string loc)
        {
            localidade=loc;
        }

        public void AlteraCodigo_Postal(string cp)
        {
            codigo_postal=cp;
        }



    }
}
