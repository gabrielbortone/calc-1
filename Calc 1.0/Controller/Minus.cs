using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_1._0.Controle
{
    class Minus : Operacao
    {
        public override double Resultado(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}
