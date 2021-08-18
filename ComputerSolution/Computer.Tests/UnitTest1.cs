using System;
using Xunit;

namespace Computer.Tests
{
    public class CalculatorTester
    {
        readonly CalculatorAddition calcAddition = new CalculatorAddition();

        readonly CalculatorSubtraction calcSubtraction = new CalculatorSubtraction();

        readonly CalculatorMultiplication calcMultiplication = new CalculatorMultiplication();

        readonly CalculatorDivision calcDivision = new CalculatorDivision();

        readonly CalculatorRoot calcRoot = new CalculatorRoot();



        [Theory]
        [InlineData(3, 5)]
        [InlineData(1.213, 12346)]
        [InlineData(-12, -123)]
        [InlineData(-1.1234, -29.34)]
        [InlineData(0, 0)]
        public void CanDoAdditionWithAllNormalNums(double summand, double addend)
        {
            double sum = calcAddition.Add(summand, addend);
            Assert.True(sum.Equals(summand + addend), $"Both sums should be the same: Object-Sum: {sum} Expected-Sum: {summand + addend}");
        }

        [Theory]
        [InlineData(double.MaxValue, double.MaxValue)]
        [InlineData(double.MinValue, double.MinValue)]
        public void AdditionThrowsExceptionWhenNumberIsTooBigOrSmall(double summand, double addend)
        {
            Assert.Throws<ArithmeticException>(() => calcAddition.Add(summand, addend));
        }



        [Theory]
        [InlineData(3, 5)]
        [InlineData(1.213, 12346)]
        [InlineData(-12, -123)]
        [InlineData(-1.1234, -29.34)]
        [InlineData(0, 0)]
        public void CanDoSubtractionWithAllNormalNums(double minuend, double subtrahend)
        {
            double difference = calcSubtraction.Subtract(minuend, subtrahend);
            Assert.True((minuend - subtrahend).Equals(difference), $"Both differences should be the same: Object-Sum: {difference} Expected-Sum: {minuend - subtrahend}");
        }

        [Theory]
        [InlineData(double.MaxValue, double.MinValue)]
        [InlineData(double.MinValue, double.MaxValue)]
        public void SubtractionThrowsExceptionWhenLessThanMinOrMoreThanMax(double minuend, double subtrahend)
        {
            Assert.Throws<ArithmeticException>(() => calcSubtraction.Subtract(minuend, subtrahend));
        }



        [Theory]
        [InlineData(3, 5)]
        [InlineData(6.1234, 8345)]
        [InlineData(-12, -95)]
        [InlineData(-1.834, -345.34)]
        [InlineData(0, 0)]
        public void CanDoMultiplicationWithNormalNums(double factor, double multiplicand)
        {
            double product = calcMultiplication.Multiply(factor, multiplicand);
            Assert.True((factor * multiplicand).Equals(product), $"Both differences should be the same: Object-Sum: {product} Expected-Sum: {factor * multiplicand}");
        }

        [Theory]
        [InlineData(double.MaxValue, double.MaxValue)]
        [InlineData(double.MinValue, double.MinValue)]
        public void MultiplicationThrowsExceptionWhenNumberMoreThanMaxOrLessThanMin(double factor, double multiplicand)
        {
            Assert.Throws<ArithmeticException>(() => calcMultiplication.Multiply(factor, multiplicand));
        }



        [Theory]
        [InlineData(3, 5)]
        [InlineData(1.213, 12346)]
        [InlineData(-99, -188881)]
        [InlineData(-1.1234, -29.34)]
        public void DividingWithNormalNumsWorks(double dividend, double divisor)
        {
            double product = calcDivision.Divide(dividend, divisor);
            Assert.True((dividend / divisor).Equals(product), $"Both differences should be the same: Object-Sum: {product} Expected-Sum: {dividend / divisor}");
        }

        [Theory]
        [InlineData(double.MaxValue, 0.1)]
        [InlineData(double.MinValue, -0.1)]
        public void DivideThrowExceptionWhenMoreThanMaxOrLessThanMin(double dividend, double divisor)
        {
            Assert.Throws<ArithmeticException>(() => calcDivision.Divide(dividend, divisor));
        }


        [Theory]
        [InlineData(1.5, 0)]
        public void ThrowExceptionWhenDividingByZero(double dividend, double divisor)
        {
            Assert.Throws<DivideByZeroException>(() => calcDivision.Divide(dividend, divisor));
        }

        [Theory]
        [InlineData(69, 0)]
        public void ThrowExceptionWhenDegreeOfRootIsZero(double degree, double radicand)
        {
            Assert.Throws<DivideByZeroException>(() => calcRoot.GetRootWithDegreeOfRadicand(degree, radicand));
        }

        [Fact]
        public void RootIsAccurate()
        {
            bool isRootMethodEqualToRealResult = Math.Round(calcRoot.GetRootWithDegreeOfRadicand(3, 25), 9).Equals(Math.Round(2.92401773821287, 9));
            Assert.True(isRootMethodEqualToRealResult, $"Actual Value is: {calcRoot.GetRootWithDegreeOfRadicand(3, 25)}");
        }

        //TODO: Block usage of - base 
    }
}
