using NUnit.Framework;
using RationalNumbers;
using System;

namespace RationalNumbers.Tests
{
    [TestFixture]
    public class RationalNumberTests
    {
        [Test]
        public void Constructor_ValidInput_CreatesCorrectRationalNumber()
        {
            RationalNumber rationalNumber = new RationalNumber(1, 2);
            Assert.AreEqual(1, rationalNumber.Numerator);
            Assert.AreEqual(2, rationalNumber.Denominator);
        }

        [Test]
        public void Constructor_DenominatorZero_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RationalNumber(1, 0));
        }

        [Test]
        public void ToString_IntegerFraction_ReturnsCorrectStringRepresentation()
        {
            RationalNumber rationalNumber = new RationalNumber(3, 1);
            Assert.AreEqual("3", rationalNumber.ToString());
        }

        [Test]
        public void ToString_NormalFraction_ReturnsCorrectStringRepresentation()
        {
            RationalNumber rationalNumber = new RationalNumber(1, 2);
            Assert.AreEqual("1/2", rationalNumber.ToString());
        }

        [Test]
        public void Addition_AddTwoRationalNumbers_ReturnsCorrectResult()
        {
            RationalNumber a = new RationalNumber(1, 2);
            RationalNumber b = new RationalNumber(1, 3);
            RationalNumber result = a + b;
            Assert.AreEqual(new RationalNumber(5, 6), result);
        }

        [Test]
        public void Subtraction_SubtractTwoRationalNumbers_ReturnsCorrectResult()
        {
            RationalNumber a = new RationalNumber(3, 4);
            RationalNumber b = new RationalNumber(1, 4);
            RationalNumber result = a - b;
            Assert.AreEqual(new RationalNumber(1, 2), result);
        }

        [Test]
        public void Multiplication_MultiplyTwoRationalNumbers_ReturnsCorrectResult()
        {
            RationalNumber a = new RationalNumber(2, 3);
            RationalNumber b = new RationalNumber(3, 5);
            RationalNumber result = a * b;
            Assert.AreEqual(new RationalNumber(6, 15), result);
        }

        [Test]
        public void Division_DivideTwoRationalNumbers_ReturnsCorrectResult()
        {
            RationalNumber a = new RationalNumber(2, 3);
            RationalNumber b = new RationalNumber(3, 4);
            RationalNumber result = a / b;
            Assert.AreEqual(new RationalNumber(8, 9), result);
        }

        [Test]
        public void UnaryNegation_NegateRationalNumber_ReturnsCorrectResult()
        {
            RationalNumber a = new RationalNumber(3, 5);
            RationalNumber result = -a;
            Assert.AreEqual(new RationalNumber(-3, 5), result);
        }

        [Test]
        public void Equality_CompareTwoEqualRationalNumbers_ReturnsTrue()
        {
            RationalNumber a = new RationalNumber(1, 2);
            RationalNumber b = new RationalNumber(1, 2);
            Assert.IsTrue(a == b);
        }

        [Test]
        public void Inequality_CompareTwoUnequalRationalNumbers_ReturnsTrue()
        {
            RationalNumber a = new RationalNumber(1, 2);
            RationalNumber b = new RationalNumber(2, 3);
            Assert.IsTrue(a != b);
        }

        [Test]
        public void LessThan_CompareTwoRationalNumbers_ReturnsTrue()
        {
            RationalNumber a = new RationalNumber(1, 2);
            RationalNumber b = new RationalNumber(3, 4);
            Assert.IsTrue(a < b);
        }

        [Test]
        public void GreaterThan_CompareTwoRationalNumbers_ReturnsTrue()
        {
            RationalNumber a = new RationalNumber(3, 4);
            RationalNumber b = new RationalNumber(1, 2);
            Assert.IsTrue(a > b);
        }

        // Добавьте еще тесты для других операторов сравнения и крайних случаев, если необходимо

    }
}
