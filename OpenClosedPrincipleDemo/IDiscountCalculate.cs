using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleDemo
{
   public interface IDiscountCalculate
    {
       bool Rule(string RuleName);
       double Calculate(int Amount);
    }

   public class IRuleDiscountCalculator : IDiscountCalculate
   {

       public bool Rule(string RuleName)
       {
           return "iday".Equals(RuleName);
       }

       public double Calculate(int Amount)
       {
           return Amount * 0.40;
       }
   }
}
