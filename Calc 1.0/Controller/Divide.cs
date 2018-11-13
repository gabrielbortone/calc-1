using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_1._0.Controle
{
    class Divide : Operacao
    {
        public override double Resultado(double num1, double num2)
        {
            try
            {
                return num1 / num2;
            }
            catch
            {
                return 0;
            }
        }
    }
}
