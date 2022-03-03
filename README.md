# Sparta Global: Code Katas
 The Code Kata tasks Completed During Sparta Global Training

> Index
> 
> * [Code Kata 1: Vowels In A String](#Code-Kata-1-Vowels-In-A-String)
> * [Code Kata 2: Days And Weeks](#Code-Kata-2-Days-And-Weeks)
> * [Code Kata 3 Who Likes It?](#Code-Kata-3-Who-Likes-It)
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

## Code Kata 3 Who Likes It
The task required:
>You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.
>
>Implement the function which takes an array containing the names of people that like an item. It must return the display text as shown in the examples:
>
>[]                                -->  "no one likes this"
>
>["Peter"]                         -->  "Peter likes this"
>
>["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
>
>["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
>
>["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"
>
>Note: For 4 or more names, the number in "and 2 others" simply increases.

This task has the simple input of an array of strings containing names. This is useful as the length of this array will give you the number of people who have liked this, with the contents being the names to be displayed. This means that the `.Length` method can be used to create a simple solution to the kata.

```csharp
switch (name.Length)
        {
            case 0:
                return "no one likes this";
            case 1:
                return $"{name[0]} likes this";
            case 2:
                return $"{name[0]} and {name[1]} like this";
            case 3:
                return $"{name[0]}, {name[1]} and {name[2]} like this";
            default:
                return $"{name[0]}, {name[1]} and {name.Length - 2} others like this"; // The -2 accounts for the names mentioned
        }
```

## Code Kata 4 Duplicate Letters
The task required:
>Create a method which takes a string and returns an array of duplicate letters e.g. "Nishant Mandal" => (a,n).
>
>Include unit tests.

The first action in this task is to convert all of the characters in the string to lower case in order to make them easier to search (via the use of the `.ToLower()` operator. The rest of the method makes use of an array of integers to store the number of each letters (a memory intensive solution that I will come back to). With the method using a `ForEach` loop to cycle through each letter in the input and add to any integer values for each letter present. There is then a loop to find the values over 1 in this array (the duplicated letters) and then add these to the output array of chars.

```csharp
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
```

The tests for this system where then a simple variety of test cases with multiple duplicates and cases where no letter is duplicated.

## Code Kata 5 Second Largest Number
The task required:
>Finding the second largest number in an array while, considering edge cases: empty arrays, arrays with one number, arrays where all the numbers are the same

To solve this issue I made use of two `for loops`, with one of them used to first find the largest value in the system and store its position in the array. By storing the position of the largest value in the array, it means it can be ignored by the second `for loop` using the same method as the first.

```csharp
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
```

## Code Kata 6 Closest To Zero
The task required:
>Find the number closest to zero - consider all numbers being the same in the array/list, negative numbers, numbers that are the same distance from zero (ie 2 and 2).

To complete the task I first focused on the issue of having both positive and negative numbers input into the system. This was accounted for by the use of the `Math.Abs()` method as this converts all of the digits to positives. I also made use of a `String Builder` class when crafting the output to the system as this reduces the memory usage of the system.

```csharp
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
```
