using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BasicMathLab; 

//using Unit Test intead of NUnit Framework


namespace BasicMathLabTest
{

    //Test class for BasicMathClass
    [TestClass]
    public class BasicMathLabTest
    {

        //Instande of BasicMath class for the following tests
        private BasicMath calculator;


        //Method to set up my test environment
        [TestInitialize]
        public void Setup()
        {
            //Initialize BasicMath instance
            calculator = new BasicMath();
        }

        //Cleans up test after
        [TestCleanup]
        public void Teardown()
        {
            calculator = null;
        }

        //Test method to test Add method of BasicMath
        [TestMethod]
        public void Test_AddMethod()
        {
            // Arrange
            double num1 = 4;
            double num2 = 44;
            double expected = 48;

            // Act: Performs addition
            double result = calculator.Add(num1, num2);

            // Assert: Checks if result = expected
            Assert.AreEqual(expected, result);
        }

        //Test method to test Subtraction method of BasicMath
        [TestMethod]
        public void Test_SubtractMethod()
        {
            // Arrange
            double num1 = 50;
            double num2 = 20;
            double expected = 30;

            // Act: Performs subtraction
            double result = calculator.Subtract(num1, num2);

            // Assert: Checks if result = expected
            Assert.AreEqual(expected, result);
        }

        //Test method to test Multiplication method of BasicMath
        [TestMethod]
        public void Test_MultiplyMethod()
        {
            // Arrange
            double num1 = 5;
            double num2 = 6;
            double expected = 30;

            // Act: Performs multiplication
            double result = calculator.Multiply(num1, num2);

            // Assert: Checks if result = expected
            Assert.AreEqual(expected, result);
        }

        //Test method to test Dividion method of BasicMath
        [TestMethod]
        public void Test_DivideMethod()
        {
            // Arrange
            double num1 = 10;
            double num2 = 2;
            double expected = 5;

            // Act: Performs division
            double result = calculator.Divide(num1, num2);

            // Assert: Checks if result = expected
            Assert.AreEqual(expected, result);
        }
    }
}