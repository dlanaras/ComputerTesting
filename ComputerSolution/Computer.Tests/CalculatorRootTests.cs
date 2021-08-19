using System;
using Xunit;
using System.Collections.Generic;


namespace Computer.Tests
{
    public class CalculatorRootTests
    {
        [Theory]
        [InlineData(0, 69)]
        public void ThrowExceptionWhenDegreeOfRootIsZero(double degree, double radicand)
        {
            Assert.Throws<DivideByZeroException>(() => CalculatorRoot.GetRootWithDegreeOfRadicand(degree, radicand));
        }

        [Fact]
        public void RootIsAccurate()
        {
            bool isRootMethodEqualToRealResult = Math.Round(CalculatorRoot.GetRootWithDegreeOfRadicand(3, 25), 9).Equals(Math.Round(2.92401773821287, 9));
            Assert.True(isRootMethodEqualToRealResult, $"Actual Value is: {CalculatorRoot.GetRootWithDegreeOfRadicand(3, 25)}");
        }

        [Theory]
        [InlineData(double.PositiveInfinity, double.PositiveInfinity)]
        public void ThrowExceptionWhenRootResultIsInfinite(double degree, double radicand)
        {
            Assert.Throws<OverflowException>(() => CalculatorRoot.GetRootWithDegreeOfRadicand(degree, radicand));
        }
    }
}