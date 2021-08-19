using System;
using Xunit;
using System.Collections.Generic;


namespace Computer.Tests
{
    public class CalculatorMultiplicateTests
    {
        [Theory]
        [InlineData(3, 5)]
        [InlineData(6.1234, 8345)]
        [InlineData(-12, -95)]
        [InlineData(-1.834, -345.34)]
        [InlineData(0, 0)]
        public void CanDoMultiplicationWithNormalNums(double factor, double multiplicand)
        {
            double product = CalculatorMultiplication.Multiply(factor, multiplicand);
            Assert.True((factor * multiplicand).Equals(product), $"Both differences should be the same: Object-Sum: {product} Expected-Sum: {factor * multiplicand}");
        }

        [Theory]
        [InlineData(double.MaxValue, double.MaxValue)]
        [InlineData(double.MinValue, double.MinValue)]
        public void MultiplicationThrowsExceptionWhenNumberMoreThanMaxOrLessThanMin(double factor, double multiplicand)
        {
            Assert.Throws<OverflowException>(() => CalculatorMultiplication.Multiply(factor, multiplicand));
        }
    }
}