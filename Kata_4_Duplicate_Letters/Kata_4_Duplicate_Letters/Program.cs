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
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        int location;
        foreach(char letter in lowerCaseInput)
        {
            location = alphabet.IndexOf(letter);
            if (location != -1) 
            {
                letterNos[location]++;
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