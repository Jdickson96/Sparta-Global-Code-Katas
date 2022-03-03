using Closest_To_Zero;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        [TestCase("Lowest Value is: 2 at position/s: 0,1,2,3,4")]
        [Category("All Inputs the Same")]
        public void GivenSameDigitArray_ClosestToZero_ReturnsClosestValue(string expected)
        {
            var inputNumbers = new int[] { 2, 2, 2, 2, 2 };
            Assert.That(Method.ClosestToZero(inputNumbers), Is.EqualTo(expected));
        }

        [Test]
        [TestCase("Lowest Value is: 1 at position/s: 0")]
        [Category("Negative Inputs")]
        public void GivenNegativeDigitArray_ClosestToZero_ReturnsClosestValue(string expected)
        {
            var inputNumbers = new int[] { -1, 2, 3, 4, 5 };
            Assert.That(Method.ClosestToZero(inputNumbers), Is.EqualTo(expected));
        }

        [Test]
        [TestCase("Lowest Value is: 4 at position/s: 0,1")]
        [Category("Inputs Same Distance From Zero")]
        public void GivenSameDistDigitArray_ClosestToZero_ReturnsClosestValue(string expected)
        {
            var inputNumbers = new int[] { -4, 4, 6, 7, 10 };
            Assert.That(Method.ClosestToZero(inputNumbers), Is.EqualTo(expected));
        }
    }
}