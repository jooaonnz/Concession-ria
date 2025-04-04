using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anotções_Interface
{
    public class Caminhao : Veiculo
    {
        public Caminhao(string modelo, string marca, int ano, decimal valorBase)

       : base(modelo, marca, ano, valorBase) { }


        public override decimal CalcularDias(int dias)
        {
            decimal percentual = 1.2m;
            return base.CalcularDias(dias) * percentual;

        }


    }
}
