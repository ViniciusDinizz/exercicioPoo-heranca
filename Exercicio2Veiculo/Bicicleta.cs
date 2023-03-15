using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2Veiculo
{
    internal class Bicicleta : Veiculo
    {
        public string catraca { get; set; }
        public string pedal { get; set; }

        public string ToString()
        {
            return base.ToString() + "| Qut.Catraca: " + catraca+"| MarcaPedal: "+pedal;
        }
    }
}
