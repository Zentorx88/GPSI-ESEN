using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M9_11H_N23
{
    class Morada
    {
        string rua, localidade, codigo_postal;

        public string DevolverRua()
        {
            return rua;
        }

        public Morada()
        {

        }

        public Morada(string rua, string localidade, string codigo_postal)
        {
            this.rua = rua;
            this.localidade = localidade;
            this.codigo_postal = codigo_postal;
        }
    }
}
