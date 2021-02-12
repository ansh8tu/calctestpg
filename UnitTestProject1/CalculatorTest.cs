using DemoTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Npgsql;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Calculator_Add_Sum_Regular_Numbers()
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            double actual_result = calc.Add(TestData.Calculator_Add_Sum_Regular_Numbers_param1,
                TestData.Calculator_Add_Sum_Regular_Numbers_param2);

            // Assert
            //Assert.IsTrue(actual_result == TestData.Calculator_Add_Sum_Regular_Numbers_result);
            Assert.IsTrue(actual_result == TestData.Calculator_Add_Sum_Regular_Numbers_result);
            // 1.0
            // 0.999999999999999999999999999999
        }

        [TestMethod]
        public void Calculator_Add_Sum_Big_Numbers()
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            double actual_result = calc.Add(TestData.Calculator_Add_Sum_Big_Numbers_param1,
                TestData.Calculator_Add_Sum_Big_Numbers_param2);

            // Assert
            //Assert.IsTrue(actual_result == TestData.Calculator_Add_Sum_Regular_Numbers_result);
            Assert.IsTrue(actual_result == TestData.Calculator_Add_Sum_Big_Numbers_result);
            // 1.0
            // 0.999999999999999999999999999999
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Calculator_Div_Divide_By_Zero_Exception()
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            double actual_result = calc.Div(TestData.Calculator_Div_Regular_Numbers_param1,
                TestData.Calculator_Div_Regular_Numbers_param2);

            // Assert
            Assert.Fail("This should have raised an exception!");
        }
    }
}
