using System;
using Xunit;
using System.Collections.Generic;


namespace Computer.Tests
{
    public class CalculatorExponentTests
    {

        [Theory]
        [InlineData(1234)]
        [InlineData(-1234)]
        [InlineData(12.34)]
        [InlineData(-12.34)]
        public void ExponentZeroAlwaysResultsToOne(double baseNum)
        {
            Assert.True(CalculatorExponentiation.GetPowerOfBaseToExponent(baseNum, 0).Equals(1));
        }
        [Theory]
        [InlineData(3, 5)]
        [InlineData(1213, 3)]

        //IMPORTANT: Add Math.Round so that not 100% accurate decimal numbers can be compared
        public void ExponentiationWorksWithNormalNums(double baseNum, double exponent)
        {
            Assert.True(CalculatorExponentiation.GetPowerOfBaseToExponent(baseNum, exponent).Equals(Math.Pow(baseNum, exponent)), $"Actual: {CalculatorExponentiation.GetPowerOfBaseToExponent(baseNum, exponent)} Expected: {Math.Pow(baseNum, exponent)}");
        }

        [Fact]
        public void MinusExponentsAndBasesAreDisabledSinceTheyCannotBeComparedToMathPow()
        {
            Assert.Throws<OverflowException>(() => CalculatorExponentiation.GetPowerOfBaseToExponent(-5, -5));
        }

        [Fact]
        public void ThrowExceptionIfMoreThanInfinite()
        {
            Assert.Throws<OverflowException>(() => CalculatorExponentiation.GetPowerOfBaseToExponent(Double.MaxValue, Double.MaxValue));
        }
    }
}