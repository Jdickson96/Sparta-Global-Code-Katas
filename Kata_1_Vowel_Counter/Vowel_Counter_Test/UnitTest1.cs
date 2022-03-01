using CodeToTest;
using NUnit.Framework;

namespace Vowel_Counter_Test
{
   class Tests
    {

        [TestCase("llllyyyggg")]
        [Category("No Vowels")]
        public void GivenNoVowels_VowelNo_ReturnsZero(string words)
        {
            Assert.That("Number of Vowels in \"llllyyyggg\" is:0", Is.EqualTo(VowelCounter.VowelNo(words)));
        }

        [TestCase("eiEIo")]
        [TestCase("fIfIfIfIfI")]
        [Category("Mix of Cases")]
        public void GivenAMixOfCases_VowelNo_ReturnsCorrectValue(string words)
        {
            Assert.That("Number of Vowels in \"" + words + "\" is:5", Is.EqualTo(VowelCounter.VowelNo(words)));
        }
    }
}