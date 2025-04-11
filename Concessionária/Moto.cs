using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anotções_Interface
{
    public class Moto : Veiculo
    {

        public Moto(string modelo, string marca, int ano, decimal valorBase)

       : base(modelo, marca, ano, valorBase) { }



        public override decimal CalcularDias(int dias)
        {
            decimal percentualRestante = 0.9m;
            return base.CalcularDias(dias) * percentualRestante;
        }

    }
}
