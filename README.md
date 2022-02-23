# Sparta-Global-Code-Katas
 The Code Katas Completed During Sparta Global Training

## Code Kata 1: Vowels In A String
The task was to:
>Create a method which takes a String and returns the number of vowels in that string and then write unit tests.

This code converts a string into lowercase in order to make searching each character easier. It simply checks each character in the string individually to see if its a vowel, then adds one to a value if there is a vowel present.

```csharp
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
        return ("Number of Vowels in \"" + input + "\" is:" + vowelNo); 
```

### The Testing Code
The testing code has a couple of test cases in order to check if a case with no vowels or one with a mixture of cases will work.

```csharp
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
```

## Code Kata 2: Days And Week
> Write a method which takes a number of day, and returns the number of weeks and leftover days it represents as a string. E.g. Given 8, your method should return "1 week/s and 1 day/s"

> BONUS FOR: 
> - Using StringBuilder/StringBuffer
> - One line method
> - Doing all of the above!
I broke this code down in to a seper
