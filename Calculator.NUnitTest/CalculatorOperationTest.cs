using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.NUnitTest
{
    [TestFixture]
    public class CalculatorOperationTest
    {
        /// <summary>
        /// jlo
        /// </summary>
        [Test]
        public void resultShouldBeThirteen()
        {
            CalculatorOperation calculatorOperation = new CalculatorOperation();

            float result = calculatorOperation.add(7, 6);

            Assert.That(result, Is.EqualTo(13));
        }


        /// <summary>
        /// opy
        /// </summary>
        [Test]
        public void resultShouldBeFortyTwo()
        {
            CalculatorOperation calculatorOperation = new CalculatorOperation();

            float result = calculatorOperation.mul(7, 6);

            Assert.That(result, Is.EqualTo(42));
        }
    }
}
