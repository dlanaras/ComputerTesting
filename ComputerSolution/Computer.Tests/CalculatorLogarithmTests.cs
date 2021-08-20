using System;
using Xunit;
using System.Collections.Generic;


namespace Computer.Tests
{
    public class CalculatorLogarithmTests
    {

        [Theory]
        [InlineData(2, 8)]
        [InlineData(10, 100)]
        public void LogWorksOnIntegers(double logBase, double logRadicand)
        {
            double calcLogResult = CalculatorLogarithm.LogWithBaseAndRadicand(logBase, logRadicand);
            Assert.True(calcLogResult.Equals(Math.Log(logRadicand, logBase)), $"Actual result: {calcLogResult}, Expected result: {Math.Log(logRadicand, logBase)}");
        }


        [Fact]
        public void ThrowsExceptionWhenNumsAreNegative()
        {
            Assert.Throws<NumberCannotBeNegativeException>(() => CalculatorLogarithm.LogWithBaseAndRadicand(-1, -1));
        }

        [Fact]
        public void BigNumbersOrInfiniteLoopsThrowException()
        {
            Assert.Throws<OverflowException>(() => CalculatorLogarithm.LogWithBaseAndRadicand(10, 1.5));
        }
    }
}