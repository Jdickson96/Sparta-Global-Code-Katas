using CodeToTest;
using NUnit.Framework;

namespace Days_Weeks_Test
{
    public class Tests
    {

        [TestCase(-8)]
        [Category("Out of Range Testing")]
        public void GivenAtimeBetween5and12Inclusive_Greeting_ReturnsGoodEvening(int testDays)
        {
            Assert.That("-1 Week/s and -1 Day/s", Is.EqualTo(WeekAndDayCalculator.FullStringConcat(testDays)));
        }

        [TestCase(7)]
        [Category("Edge Testing")]
        public void GivenAtimeBetween12and18Inclusive_Greeting_ReturnsGoodAfternoon(int testDays)
        {
            Assert.That("1 Week/s and 0 Day/s", Is.EqualTo(WeekAndDayCalculator.FullStringConcat(testDays)));
        }
    }
}