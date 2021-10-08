using System;
using Xunit;
using Calculator_1;
using System.Collections.Generic;
using System.Text;

namespace Calculator_1.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void AdditionTests()
        {
            double n1 = 11;
            double n2 = 23;
            double expectresult = 34;
            double result = Calculator.Addition(n1, n2);

            Assert.Equal(expectresult, result);
        }
        [Fact]
        public static void SubtractionTests()
        {
            double n1 = 12;
            double n2 = 10;
            double expected = 2;

            double result = Calculator.Subtraction(n1, n2);

            Assert.Equal(expected, result);
        }
        [Fact]
        public static void MultiplicationTests()
        {
            double n1 = 12;
            double n2 = 10;
            double expected = 120;

            double result = Calculator.Multiplication(n1, n2);

            Assert.Equal(expected, result);
        }
        [Fact]
        public static void DivisionTests()
        {
            double n1 = 12;
            double n2 = 2;
            double expected = 6;

            double result = Calculator.Division(n1, n2);

            Assert.Equal(expected, result);
        }
        [Fact]
        public static void DivisionzeroTests()
        {
            double n1 = 12;
            double n2 = 0;


            double result = Calculator.Division(n1, n2);

            Assert.True(double.IsInfinity(result));
        }
        [Theory]
        [InlineData (new double [] { 1,4,3})]
        public void AdditionTestso(double[] number)
        {
            
            double result = 8;
            double expected = Calculator.Addition(number);

            Assert.Equal(result, expected);
        }
        [Theory]
        [InlineData(new double[] { 1, 4, 3 })]
        public void SubtractionTestso(double[] number)
        {
           
            double result = -6;
            double expected = Calculator.Subtraction(number);

            Assert.Equal(result, expected);
        }
        
    }
}
