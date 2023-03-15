using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2Veiculo
{
    internal class Carro : Veiculo
    {
        public string modelo { get; set; }
        public int estqNovo { get; set; }
        public string ToString()
        {
            return base.ToString() + " | Ger.: " + modelo + " - Estq 0km: " +estqNovo;
        }
    }
}
