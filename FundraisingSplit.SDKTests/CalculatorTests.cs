using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundraisingSplit.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundraisingSplit.SDK.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void CalculateNAVTest()
        {
            var total = 600000;
            var stock = 10000;
            var except = 60;
            var result = Calculator.CalculateNAV(total, stock);
            Assert.AreEqual(result, except);
        }

        [TestMethod()]
        public void CalculateStockTest()
        {
            var amount = 600;
            var nav = 60;
            var except = 10;
            var result = Calculator.CalculateStock(nav, amount);
            Assert.AreEqual(result, except);
        }

        [TestMethod()]
        public void CalculateWithdrawAmountTest()
        {
            var stock = 100;
            var nav = 60;
            var except = 6000;
            var result = Calculator.CalculateWithdrawAmount(nav, stock);
            Assert.AreEqual(result, except);
        }

        [TestMethod()]
        public void CalculateWithdrawStockTest()
        {
            var amount = 10000;
            var nav = 100;
            var except = 100;
            var result = Calculator.CalculateWithdrawStock(nav, amount);
            Assert.AreEqual(result, except);
        }
    }
}