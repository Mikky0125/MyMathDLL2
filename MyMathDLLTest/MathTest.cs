using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMathDLL;


namespace MyMathDLLTest
{
    [TestClass]
    public class MathTest
    {
        
        MyMath m = new MyMath();
        [TestMethod]
        public void AddTest()
        {
            
            Assert.IsTrue(m.Add(2,3).Equals(5)); 
        }
        [TestMethod]
        public void addTestNegativeNumber()
        {
            Assert.AreEqual(m.Add(-3, -4), -7);
        }
        [TestMethod]
        public void MultipleTest()
        {
            Assert.AreEqual(m.Multiple(2, 4), 8);
        }
        [TestMethod]
        public void DivideTest()
        {
            Assert.AreEqual(m.Divide(6, 2), 3);
        }



    }
}
