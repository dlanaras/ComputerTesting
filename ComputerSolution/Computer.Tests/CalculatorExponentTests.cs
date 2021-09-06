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

        public void ExponentiationWorksWithNormalNums(double baseNum, double exponent)
        {
            double exponentResult =  Math.Round(CalculatorExponentiation.GetPowerOfBaseToExponent(baseNum, exponent), 6);
            double expectedResult = Math.Round(Math.Pow(baseNum, exponent), 6);
            Assert.True(exponentResult.Equals(expectedResult), $"Actual: {exponentResult} Expected: {expectedResult}");
        }

        [Fact]
        public void MinusExponentsAndBasesAreDisabledSinceTheyCannotBeComparedToMathPow()
        {
            Assert.Throws<NumberCannotBeNegativeException>(() => CalculatorExponentiation.GetPowerOfBaseToExponent(-5, -5));
        }

        [Fact]
        public void ThrowExceptionIfMoreThanInfinite()
        {
            Assert.Throws<OverflowException>(() => CalculatorExponentiation.GetPowerOfBaseToExponent(Double.MaxValue, Double.MaxValue));
        }
    }
}