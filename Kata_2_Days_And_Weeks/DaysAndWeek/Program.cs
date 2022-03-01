using System;
namespace CodeToTest;
    public class WeekAndDayCalculator
    {
        static int Weeks(int input)
        {
            int weekNo = input / 7;

            return weekNo;
        }

        static int Days(int input)
        {
            int dayNo = input % 7;
            return dayNo;
        }

        public static string FullStringConcat(int input)
    {
        return (Weeks(input) + " Week/s and " + Days(input) + " Day/s");
    }

        static void Main(string[] args)
        {
            int testTotalDays = 8;    //Value to be tested
            System.Console.WriteLine(FullStringConcat(testTotalDays));
        }
    }