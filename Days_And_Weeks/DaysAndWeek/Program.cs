class WeekAndDayCalculator
{
    static int Weeks(int input)
    {
        int weekNo = input/7;
  
        return weekNo;
    }

    static int Days(int input)
    {
        int dayNo = input % 7;
        return dayNo;
    }

    static void Main(string[] args)
    {
        int testTotalDays = 8;    //Value to be tested

        System.Console.WriteLine("{0} Week/s and {2} Day/s", Weeks(testTotalDays), Days(testTotalDays) );
    }
}