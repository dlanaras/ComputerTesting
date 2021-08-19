using System;
using Xunit;
using System.Collections.Generic;

namespace Computer.Tests
{
    public class CalculatorOperationConverterTester
    {

        [Fact]
        public void UserCannotChooseInvalidOperation()
        {
            Assert.Throws<InvalidOperationException>(() => CalculatorInputToOperationsConvertor.ReturnUserInputAsOperation("planet"));
        }

        [Theory]
        [InlineData("Add")]
        [InlineData("ADD")]
        [InlineData("add")]
        public void OperationGetsChosenRegardlessOfCapitalization(string operation)
        {
            Assert.True(CalculatorInputToOperationsConvertor.ReturnUserInputAsOperation(operation).Equals(CalculatorOperations.Add));
        }
    }
}
