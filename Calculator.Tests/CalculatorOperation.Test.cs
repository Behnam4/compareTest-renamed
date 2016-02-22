using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorOperationTest
    {
        /// <summary>
        /// 
        /// </summary>
        // first tester method
        [TestMethod]
        public void resultShouldBeThirteenWhenPassSevenSix()
        {
            CalculatorOperation calculatorOperation = new CalculatorOperation();

            float result = calculatorOperation.add(7, 6);

            Assert.AreEqual(13, result);
        }


        /// <summary>
        /// 
        /// </summary>
        // second tester method
        [TestMethod]
        public void resultShouldBeFortyTwoWhenPassSevenSix()
        {
            CalculatorOperation calculatorOperation = new CalculatorOperation();

            float result = calculatorOperation.mul(7, 6);

            Assert.AreEqual(42, result);
          
        }
    }
}
