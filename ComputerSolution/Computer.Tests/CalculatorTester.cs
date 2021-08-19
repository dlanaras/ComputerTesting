using System;
using Xunit;
using System.Collections.Generic;


//TODO: Seperate this in multiple classes depending on which class is being tested
namespace Computer.Tests
{
    public class CalculatorTester
    {
        readonly CalculatorAddition calcAddition = new CalculatorAddition();

        readonly CalculatorSubtraction calcSubtraction = new CalculatorSubtraction();

        readonly CalculatorMultiplication calcMultiplication = new CalculatorMultiplication();

        readonly CalculatorDivision calcDivision = new CalculatorDivision();

        readonly CalculatorRoot calcRoot = new CalculatorRoot();

        readonly CalculatorExponentiation calcExponent = new CalculatorExponentiation();

        readonly CalculatorLogarithm calcLog = new CalculatorLogarithm();


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
        [InlineData(0, 69)]
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

        [Theory]
        [InlineData(double.PositiveInfinity, double.PositiveInfinity)]
        public void ThrowExceptionWhenRootResultIsInfinite(double degree, double radicand)
        {
            Assert.Throws<ArithmeticException>(() => calcRoot.GetRootWithDegreeOfRadicand(degree, radicand));
        }



        [Theory]
        [InlineData(1234)]
        [InlineData(-1234)]
        [InlineData(12.34)]
        [InlineData(-12.34)]
        public void ExponentZeroAlwaysResultsToOne(double baseNum)
        {
            Assert.True(calcExponent.GetPowerOfBaseToExponent(baseNum, 0).Equals(1));
        }


        [Theory]
        [InlineData(3, 5)]
        [InlineData(1.213, 12346)]
        public void ExponentiationWorksWithNormalNums(double baseNum, double exponent)
        {
            Assert.True(calcExponent.GetPowerOfBaseToExponent(baseNum, exponent).Equals(Math.Pow(baseNum, exponent)), $"Actual: {calcExponent.GetPowerOfBaseToExponent(baseNum, exponent)} Expected: {Math.Pow(baseNum, exponent)}");
        }

        [Fact]
        public void MinusExponentsAndBasesAreDisabledSinceTheyCannotBeComparedToMathPow()
        {
            Assert.Throws<ArithmeticException>(() => calcExponent.GetPowerOfBaseToExponent(-5, -5));
        }


        [Theory]
        [InlineData(2, 10)]
        [InlineData(3, -10)]
        public void LogWorksOnIntegers(double logBase, double logRadicand) //FIXME:
        {
            double calcLogResult = calcLog.LogWithBaseAndRadicand(logBase, logRadicand);
            Assert.True(calcLogResult.Equals(Math.Log(logBase, logRadicand)), $"Actual result: {calcLogResult}, Expected result: {Math.Log(logBase, logRadicand)}");
        }


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
