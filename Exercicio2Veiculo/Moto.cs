using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2Veiculo
{
    internal class Moto : Veiculo
    {
        public int cilindrada { get; set; }
        public string relacao { get; set; }

        public string ToString()
        {
            return base.ToString() + " | Potencia: " + cilindrada+ "cc"+"| Kit Relação: " +relacao;
        }
    }
}
