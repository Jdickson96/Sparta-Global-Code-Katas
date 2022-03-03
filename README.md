# Sparta Global: Code Katas
 The Code Kata tasks Completed During Sparta Global Training

> Index
> 
> * [Code Kata 1: Vowels In A String](#Code-Kata-1-Vowels-In-A-String)
> * [Code Kata 2: Days And Weeks](#Code-Kata-2-Days-And-Weeks)
> * [Code Kata 3 Who Likes It?](#Code-Kata-3-Who-Likes-It?)
> * [Code Kata 4 Duplicate Letters](#Code-Kata-4-Duplicate-Letters)
> * [Code Kata 5 Second Largest Number](#Code-Kata-5-Second-Largest-Number)
> * [Code Kata 6 Closest To Zero](#Code-Kata-6-Closest-To-Zero)

## Code Kata 1 Vowels In A String
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

## Code Kata 2 Days And Weeks
> Write a method which takes a number of day, and returns the number of weeks and leftover days it represents as a string. E.g. Given 8, your method should return "1 week/s and 1 day/s"
> 
> BONUS FOR: 
> - Using StringBuilder/StringBuffer
> - One line method
> - Doing all of the above!

I broke this code down in to a seperate classes for the Day, Week and Concaternation actions being performed. This is overly broken down however while learning C and C++ I was taught to use classes and functions in order to ease debugging.

The week is simply the full number of times the value can be divided by 7.
> int weekNo = input / 7;

The number of days is simply the remainder from the value being divided by 7, found via the use of the modulus operator.
> int dayNo = input % 7;

Finally, the previously found values are concaternated via the use of the plus operator.
> return (Weeks(input) + " Week/s and " + Days(input) + " Day/s");

### The Testing Code
The NUnit testing code simply tests and out of range value along with an edge value. This ensures some level of confidence in the code, however truthfully I struggled to think of other events to test.

```csharp
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
```

## Code Kata 3 Who Likes It?


## Code Kata 4 Duplicate Letters


## Code Kata 5 Second Largest Number


## Code Kata 6 Closest To Zero

