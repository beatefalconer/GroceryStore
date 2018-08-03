using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GroceryStore1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsApple30()
        {
            Register register1 = new Register(); //arrange
            double cost = register1.calculateTotal(1, 0); //act
            Assert.AreEqual(30, cost, 0.001, "one Apple is not 30"); //assert
        }
        [TestMethod]
        public void IsBanana50()
        {
            //
            Register register2 = new Register(); //arrange
            double cost = register2.calculateTotal(0, 1); //act
            Assert.AreEqual(50, cost, 0.001, "one Banana is not 50"); //assert
        }
    }
}
