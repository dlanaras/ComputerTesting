using System;
using Xunit;
using System.Collections.Generic;

namespace Computer.Tests
{
    public class CalculatorFactorialTests
    {
        [Fact]
        public void PositiveIntegerFactorialWorks()
        {
            Assert.True(CalculatorFactorial.GetFactorialOf(4).Equals(24), $"Actual Result: {CalculatorFactorial.GetFactorialOf(4)}");
        }

        [Fact]
        public void FactorialOfZeroEvalueatesToOne()
        {
            Assert.True(CalculatorFactorial.GetFactorialOf(0).Equals(1));
        }


        [Fact]
        public void FactorialCannotBeNegative()
        {
            Assert.Throws<NumberCannotBeNegativeException>(() => CalculatorFactorial.GetFactorialOf(-1));
        }

        [Fact]
        public void FactorialCannotBeDecimal()
        {
            Assert.Throws<NumberCannotBeDecimalException>(() => CalculatorFactorial.GetFactorialOf(0.123));
        }
    }
}