using Xunit;

namespace CalculatorApp.Tests
{
    [TestFixture]
    public class Tests
    {
        private readonly Calculator _calculator;

        public Tests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            int a = 5, b = 3;

            double result = _calculator.Add(a, b);

            NUnit.Framework.Assert.AreEqual(8, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsCorrectDifference()
        {
            int a = 10, b = 6;

            double result = _calculator.Subtract(a, b);

            NUnit.Framework.Assert.AreEqual(4, result);
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsCorrectProduct()
        {
            int a = 4, b = 7;

            double result = _calculator.Multiply(a, b);

            NUnit.Framework.Assert.AreEqual(28, result);
        }

        [Fact]
        public void Divide_TwoNumbers_ReturnsCorrectQuotient()
        {
            int a = 20, b = 5;

            double result = _calculator.Divide(a, b);

            NUnit.Framework.Assert.AreEqual(4, result);
        }

        [Fact]
        public void Divide_DivisionByZero_ThrowsDivideByZeroException()
        {
            int a = 10, b = 0;

            NUnit.Framework.Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }
    }
}