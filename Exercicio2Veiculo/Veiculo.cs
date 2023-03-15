using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2Veiculo
{
    internal class Veiculo
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int QPassageiros { get; set; }
        public string Cor { get; set; }
        public int tOleo { get; set; }

        public string ToString()
        {
            return "Nome: "+this.Nome+"- "+this.Marca+ "| Cor: "+Cor+
                "| Quantidade de passageiros: " + this.QPassageiros+"| Troca Oleo: "+tOleo;
        }
    }
}
