using System;
using Xunit;
using System.Collections.Generic;


namespace Computer.Tests
{
    public class CalculatorAddTests
    {
        [Theory]
        [InlineData(3, 5)]
        [InlineData(1.213, 12346)]
        [InlineData(-12, -123)]
        [InlineData(-1.1234, -29.34)]
        [InlineData(0, 0)]
        public void CanDoAdditionWithAllNormalNums(double summand, double addend)
        {
            double sum = CalculatorAddition.Add(summand, addend);
            Assert.True(sum.Equals(summand + addend), $"Both sums should be the same: Object-Sum: {sum} Expected-Sum: {summand + addend}");
        }

        [Theory]
        [InlineData(double.MaxValue, double.MaxValue)]
        [InlineData(double.MinValue, double.MinValue)]
        public void AdditionThrowsExceptionWhenNumberIsTooBigOrSmall(double summand, double addend)
        {
            Assert.Throws<OverflowException>(() => CalculatorAddition.Add(summand, addend));
        }
    }
}