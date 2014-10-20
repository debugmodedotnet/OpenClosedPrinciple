using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleDemo
{
    class WinterDiscountCalculator : IDiscountCalculate
    {
        public bool Rule(string RuleName)
        {
            return "winter".Equals(RuleName);
        }

        public double Calculate(int Amount)
        {
            return Amount * 0.20;
        }
    }
}
