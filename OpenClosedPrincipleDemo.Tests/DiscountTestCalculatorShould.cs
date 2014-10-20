using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenClosedPrincipleDemo.Tests
{
    [TestClass]
    public class DiscountTestCalculatorShould
    {
        private DiscountService _discountcal;
        [TestInitialize]
        public void TestSetup()
        {
            _discountcal = new DiscountService();
        }

        [TestMethod]
        public void Returnfifteenpercentforsummer()
        {
            var result = _discountcal.Discount(100, "summer");
            Assert.AreEqual(15.0,result);
        }
        [TestMethod]
        public void Returnfivepercentforiday()
        {
            var result = _discountcal.Discount(100, "iday");
            Assert.AreEqual(40.0, result);
        }

       
    }
}
