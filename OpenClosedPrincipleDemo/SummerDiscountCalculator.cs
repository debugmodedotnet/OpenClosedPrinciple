using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleDemo
{
  public  class SummerDiscountCalculator : IDiscountCalculate
    {
        public bool Rule(string RuleName)
        {
            return "summer".Equals(RuleName);
        }

        public double Calculate(int Amount)
        {
            return Amount * 0.15; 
        }
    }
}
