using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2Veiculo
{
    internal class Onibus : Veiculo
    {
        public string cmpViacao { get; set; }
        public int passagens { get; set; }


        public string ToString()
        {
            return base.ToString() + " | Viacao: " + cmpViacao+ "| Qtd. Pass: "+passagens;
        }
    }
}
