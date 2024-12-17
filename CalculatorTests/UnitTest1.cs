namespace CalculatorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestFixture]
        public class CalculatorTests
        {
            [Test]
            public void TestAddition()
            {
                NUnit.Framework.Assert.That(Calculator.Add(2, 3), Is.EqualTo(6));
            }

            [Test]
            public void TestSubtraction()
            {
                NUnit.Framework.Assert.That(Calculator.Subtract(2, 3), Is.EqualTo(-1));
            }

            [Test]
            public void TestMultiplication()
            {
                NUnit.Framework.Assert.That(Calculator.Multiply(2, 3), Is.EqualTo(6));
            }

            [Test]
            public void TestDivision()
            {
                NUnit.Framework.Assert.That(Calculator.Divide(6, 3), Is.EqualTo(2));
            }

            [Test]
            public void TestDivisionByZero()
            {
                NUnit.Framework.Assert.That(() => Calculator.Divide(6, 0), Throws.Exception.TypeOf<DivideByZeroException>());
            }
        }
    }
}