using System;
using Xunit;
using System.Collections.Generic;


namespace Computer.Tests
{
    public class CalculatorDivideTests
    {

        [Theory]
        [InlineData(3, 5)]
        [InlineData(1.213, 12346)]
        [InlineData(-99, -188881)]
        [InlineData(-1.1234, -29.34)]
        public void DividingWithNormalNumsWorks(double dividend, double divisor)
        {
            double product = CalculatorDivision.Divide(dividend, divisor);
            Assert.True((dividend / divisor).Equals(product), $"Both differences should be the same: Object-Sum: {product} Expected-Sum: {dividend / divisor}");
        }

        [Theory]
        [InlineData(double.MaxValue, 0.1)]
        [InlineData(double.MinValue, -0.1)]
        public void DivideThrowExceptionWhenMoreThanMaxOrLessThanMin(double dividend, double divisor)
        {
            Assert.Throws<OverflowException>(() => CalculatorDivision.Divide(dividend, divisor));
        }

        [Theory]
        [InlineData(1.5, 0)]
        public void ThrowExceptionWhenDividingByZero(double dividend, double divisor)
        {
            Assert.Throws<DivideByZeroException>(() => CalculatorDivision.Divide(dividend, divisor));
        }
    }
}