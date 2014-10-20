using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleDemo
{
    public class DiscountService
    {
        double discountedValue;
        public List<IDiscountCalculate> _discountService;

        public DiscountService()
        {
            _discountService = new List<IDiscountCalculate>();
            _discountService.Add(new SummerDiscountCalculator());
            _discountService.Add(new WinterDiscountCalculator());
            _discountService.Add(new IRuleDiscountCalculator());
        }


        public double Discount(int Amount, string Rule)
        {
            discountedValue = _discountService.Find(i => i.Rule(Rule)).Calculate(Amount);
            return discountedValue;
        }
    }
}
