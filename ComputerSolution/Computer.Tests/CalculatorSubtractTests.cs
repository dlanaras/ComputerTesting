using System;
using Xunit;
using System.Collections.Generic;


namespace Computer.Tests
{
    public class CalculatorSubtractTests
    {
        [Theory]
        [InlineData(3, 5)]
        [InlineData(1.213, 12346)]
        [InlineData(-12, -123)]
        [InlineData(-1.1234, -29.34)]
        [InlineData(0, 0)]
        public void CanDoSubtractionWithAllNormalNums(double minuend, double subtrahend)
        {
            double difference = CalculatorSubtraction.Subtract(minuend, subtrahend);
            Assert.True((minuend - subtrahend).Equals(difference), $"Both differences should be the same: Object-Sum: {difference} Expected-Sum: {minuend - subtrahend}");
        }

        [Theory]
        [InlineData(double.MaxValue, double.MinValue)]
        [InlineData(double.MinValue, double.MaxValue)]
        public void SubtractionThrowsExceptionWhenLessThanMinOrMoreThanMax(double minuend, double subtrahend)
        {
            Assert.Throws<OverflowException>(() => CalculatorSubtraction.Subtract(minuend, subtrahend));
        }
    }
}