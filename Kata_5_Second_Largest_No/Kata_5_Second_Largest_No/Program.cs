// Find the second largest number in an array
//For the Kata, consider edge cases: empty arrays, arrays with one number, arrays where all the numbers are the same

using System;
namespace CodeToTest;

public class Program
{
    static void Main(string[] args)
    {
        int[] numberList = { 0, 1, 2, 3, 4, 2 };
        Console.WriteLine(SecondLargest(numberList));
    }

    public static int SecondLargest(int[] input)
    {
        int largestInt = input[0];
        int largestIndex = 0;
        int secondLargestInt = input[1];
        int numberOfInts = input.Length;

            {
                for (int i = 0; i < numberOfInts; i++)
                {
                    if (input[i] > largestInt)
                    {
                        largestInt = input[i];
                        largestIndex = i;
                    }
                }

                for (int i = 0; i < numberOfInts; i++)
                {
                    if (input[i] > secondLargestInt && i != largestIndex)
                    {
                        secondLargestInt = input[i];
                    }
                }
            }

            return secondLargestInt;
    }
}