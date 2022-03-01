using CodeToTest;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {   
        [Test]
        [TestCase("Nishant Mandal")]
        public void GivenName_StringToDuplicates_ReturnsDuplicateChars1(string word)
        {
            var expected = new char[] { 'a', 'n' };
            Assert.That(expected, Is.EqualTo(Program.StringToDuplicates(word)));
        }

        [Test]
        [TestCase("Tiny Tim")]
        public void GivenName_StringToDuplicates_ReturnsDuplicateChars2(string word)
        {
            var expected = new char[] { 'i', 't' };
            Assert.That(expected, Is.EqualTo(Program.StringToDuplicates(word)));
        }

        [Test]
        [TestCase("qwertyuiop")]
        public void GivenName_StringToDuplicates_ReturnsNoDuplicates(string word)
        {
            var expected = new char[] { };
            Assert.That(expected, Is.EqualTo(Program.StringToDuplicates(word)));
        }
    }
}