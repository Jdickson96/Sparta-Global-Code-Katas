class VowelCounter
{
    static int VowelNo(string input)
    {
        int vowelNo = 0;
        string lowerCaseInput = input.ToLower();    //Converts to lower case to allow for easier char search

        foreach (char character in lowerCaseInput)
        {
            if(character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            {
                vowelNo++;  //Adds to vowel Number if Vowel Present
            }
            else
            {
                //Nothing happens if no vowel
            }
        }
        return vowelNo; 
    }

    static void Main(string[] args)
    {
        string testString = "Little Test Words";    //String to be tested
        System.Console.WriteLine("Number of Vowels in \"{0}\" is: {1}", testString, VowelNo(testString));
    }  
    }