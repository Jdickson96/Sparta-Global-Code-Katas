using System;
using System.Text;

//Find the number closest to zero - consider all numbers being the same in the array/list, negative numbers, numbers that are the same distance from zero (ie 2 and 2).

namespace Closest_To_Zero
{
    public class Method
    {
        public static void Main(string[] args)
        {
            int[] data = {10,5,3,7,9,2 };
            Console.WriteLine(ClosestToZero(data));
        }

       public static string ClosestToZero(int[] input)
        {
            StringBuilder sb = new StringBuilder();
            int closestToZero = int.MaxValue;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < 0)
                {
                    input[i] = Math.Abs(input[i]);  //This converts all negative  numbers to positive
                }

                if (input[i] < closestToZero)
                {
                    sb.Clear();
                    sb.Append($"Lowest Value is: {input[i]} at position/s: {i}");
                    closestToZero = input[i];
                }
                else if (input[i] == closestToZero)
                {
                    sb.Append($",{i}");
                }
            }

            return sb.ToString();
        }
    }
}