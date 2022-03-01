using CodeToTest;
using NUnit.Framework;
using System;

namespace Tests
{
    //For the Kata, consider edge cases: empty arrays, arrays with one number, arrays where all the numbers are the same
    public class Tests
    {
        [Test]
        [TestCase(2)]
        [Category("Regular Test")]
        public void GivenDigitArray_SecondLargest_ReturnsSecondLargest(int expected)
        {
            var inputNumbers = new int[] { 1,2,3,2,1};
            Assert.That(expected, Is.EqualTo(Program.SecondLargest(inputNumbers)));
        }

        [Test]
        [TestCase(1)]
        [Category("Empty Arrays")]
        public void GivenEmptyArray_SecondLargest_ReturnsSecondLargest(int expected)
        {
            var inputNumbers = new int[] { };
            Assert.That(() => Program.SecondLargest(inputNumbers), Throws.TypeOf<IndexOutOfRangeException>());
        }

        [Test]
        [TestCase(1)]
        [Category("Arrays With One Number")]
        public void GivenAllOneNumber_SecondLargest_ReturnsSecondLargest(int expected)
        {
            var inputNumbers = new int[] {7};
            Assert.That(() => Program.SecondLargest(inputNumbers), Throws.TypeOf<IndexOutOfRangeException>());
        }

        [Test]
        [TestCase(1)]
        [Category("Arrays With All Same Number")]
        public void GivenAllSameNumber_SecondLargest_ReturnsSecondLargest(int expected)
        {
            var inputNumbers = new int[] { 1, 1, 1, 1, 1 };
            Assert.That(expected, Is.EqualTo(Program.SecondLargest(inputNumbers)));
        }
    }
}