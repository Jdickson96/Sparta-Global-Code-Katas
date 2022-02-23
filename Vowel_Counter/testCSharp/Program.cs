class VowelCounter
{
    static int LengthCalc(string input)
    {
        int vowelNo = 0;
        string lowerCaseInput = input.ToLower();    //Converts to lower case to allow for easier char search

        for (int i = 0; i < input.Length; i++)
        {
            if(lowerCaseInput[i] == 'a' || lowerCaseInput[i] == 'e' || lowerCaseInput[i] == 'i' || lowerCaseInput[i] == 'o' || lowerCaseInput[i] == 'u')
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
     
        System.Console.WriteLine("Number of Vowels in \"{0}\" is: {1}", testString, LengthCalc(testString));
    }  
    }