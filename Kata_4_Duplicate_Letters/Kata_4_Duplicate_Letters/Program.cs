//  Create a method which takes a string and returns an array of duplicate letters e.g. "Nishant Mandal" => (a,n).
using System;
namespace CodeToTest;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(StringToDuplicates("Tiny Tim"));
    }

    public static char[] StringToDuplicates(string input)
    {
        string lowerCaseInput = input.ToLower();
        
        List<char> duplicates = new List<char>();
        int[] letterNos = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        char[] alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m',
                           'n','o','p','q','r','s','t','u','v','w','x','y','z'};
        foreach(char letter in lowerCaseInput)
        {
            switch (letter)
            {
                case 'a':
                    letterNos[0]++;
                    break;
                case 'b':
                    letterNos[1]++;
                    break;
                case 'c':
                    letterNos[2]++;
                    break;
                case 'd':
                    letterNos[3]++;
                    break;
                case 'e':
                    letterNos[4]++;
                    break;
                case 'f':
                    letterNos[5]++;
                    break;
                case 'g':
                    letterNos[6]++;
                    break;
                case 'h':
                    letterNos[7]++;
                    break;
                case 'i':
                    letterNos[8]++;
                    break;
                case 'j':
                    letterNos[9]++;
                    break;
                case 'k':
                    letterNos[10]++;
                    break;
                case 'l':
                    letterNos[11]++;
                    break;
                case 'm':
                    letterNos[12]++;
                    break;
                case 'n':
                    letterNos[13]++;
                    break;
                case 'o':
                    letterNos[14]++;
                    break;
                case 'p':
                    letterNos[15]++;
                    break;
                case 'q':
                    letterNos[16]++;
                    break;
                case 'r':
                    letterNos[17]++;
                    break;
                case 's':
                    letterNos[18]++;
                    break;
                case 't':
                    letterNos[19]++;
                    break;
                case 'u':
                    letterNos[20]++;
                    break;
                case 'v':
                    letterNos[21]++;
                    break;
                case 'w':
                    letterNos[22]++;
                    break;
                case 'x':
                    letterNos[23]++;
                    break;
                case 'y':
                    letterNos[24]++;
                    break;
                case 'z':
                    letterNos[25]++;
                    break;
            }
        }
        
        for(int i=0; i<26; i++)
        {

            if (letterNos[i] > 1)
            {
                duplicates.Add(alphabet[i]);
            }
        }

        return duplicates.ToArray();
    }
}