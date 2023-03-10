using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class FactorialCalculator
    {
        public ulong Calculate(ulong number)
        {
            if (number < 2)
            {
                return 1;
            }
            return Calculate(number - 1) * number;
        }
    }
}
