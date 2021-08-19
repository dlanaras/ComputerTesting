using System;
using Xunit;
using System.Collections.Generic;

namespace Computer.Tests
{
    public class CalculatorStringToDoubleTester
    {
        [Fact]
        public void ThrowExceptionWhenUserDoesntInputNumber()
        {
            Assert.Throws<InvalidOperationException>(() => CalculatorStringToDoubleConvertor.StringToDouble("hello"));
        }

        [Theory]
        [InlineData("89")]
        [InlineData("80123.4123")]
        [InlineData("-122222222223.1234")]
        [InlineData("1.7976931348623157E+308")]
        public void StringToDoubleCorrectlyConvertsStrings(string stringToConvertToDouble)
        {
            Assert.True(CalculatorStringToDoubleConvertor.StringToDouble(stringToConvertToDouble).Equals(Double.Parse(stringToConvertToDouble)));
        }
    }
}