using System;

class OddOrEvenCounter
{
    //Petko is bad with numbers. He’s given a task to find and count some, but he has a hard time doing it. He is 
    //given N sets of numbers, and he has to count the odd numbers in each set, and then compare them. The number C shows
    //how many numbers are there in a set. Then you are given a string S holding one of the words "odd" or "even" showing
    //you what numbers should be counted.  Then you are given N * C numbers representing all sets.
    //Your task is to count the odd or even numbers in each set, and then say in which set has most S numbers.
    //The set with most S numbers should be represented as ordinal number word e.g. "First", "Second", "Third", "Fourth",
    //"Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth". If the count of one or more sets is equal, print the first
    //one with biggest count. If there is no set holding odd or even numbers print "No".  
    //Input
    //The input data should be read from the console. It consists of three input values, each at separate line:
    //•	The first line holds an integer N – the count of sets
    //•	The second line hold an integer C – the count of numbers in each set
    //•	The third line holds a string S  holding either "odd" or "even" showing what numbers to count
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output data should be printed on the console. It consists of exactly 1 line.
    //•	Print on the console the following formatted string "{0} set has the most {1} numbers: {2}", where {0} is the set as ordinal string {1} is the value of S and {2} is the biggest count of S numbers. If there is no set holding odd or even numbers print "No".   
    //Constraints
    //•	N will be an integer number in the range [1...10] 
    //•	C will be an integer number in the range [1...50] 
    //•	Each of the numbers in the set will be an integer in the range[-2 147 483 647… 2 147 483 647]
    //•	Allowed working time for your program: 0.25 seconds. Allowed memory: 16 MB.

    static void Main()
    {
        byte countOfSets = byte.Parse(Console.ReadLine());
        byte countOfNumbers = byte.Parse(Console.ReadLine());
        string oddOrEven = Console.ReadLine();
        int maxOddsSetCount = 0;
        int maxEvensSetCount = 0;
        int maxOddSetIndex = 0;
        int maxEvenSetIndex = 0;
        for (int i = 1; i <= countOfSets; i++)
        {
            int oddCount = 0;
            int evenCount = 0;
            for (int j = 0; j < countOfNumbers; j++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            if (evenCount > maxEvensSetCount)
            {
                maxEvensSetCount = evenCount;
                maxEvenSetIndex = i;
            }
            if (oddCount > maxOddsSetCount)
            {
                maxOddsSetCount = oddCount;
                maxOddSetIndex = i;
            }
        }
        string setIndexAsString = null;
        if (oddOrEven == "odd")
        {
            if (maxOddsSetCount > 0)
            {
                switch (maxOddSetIndex)
                {
                    case 1: setIndexAsString = "First"; break;
                    case 2: setIndexAsString = "Second"; break;
                    case 3: setIndexAsString = "Third"; break;
                    case 4: setIndexAsString = "Fourth"; break;
                    case 5: setIndexAsString = "Fifth"; break;
                    case 6: setIndexAsString = "Sixth"; break;
                    case 7: setIndexAsString = "Seventh"; break;
                    case 8: setIndexAsString = "Eighth"; break;
                    case 9: setIndexAsString = "Ninth"; break;
                    case 10: setIndexAsString = "Tenth"; break;
                }
                Console.WriteLine("{0} set has the most {1} numbers: {2}", setIndexAsString, oddOrEven, maxOddsSetCount);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        else
        {
            if (maxEvensSetCount > 0)
            {
                switch (maxEvenSetIndex)
                {
                    case 1: setIndexAsString = "First"; break;
                    case 2: setIndexAsString = "Second"; break;
                    case 3: setIndexAsString = "Third"; break;
                    case 4: setIndexAsString = "Fourth"; break;
                    case 5: setIndexAsString = "Fifth"; break;
                    case 6: setIndexAsString = "Sixth"; break;
                    case 7: setIndexAsString = "Seventh"; break;
                    case 8: setIndexAsString = "Eighth"; break;
                    case 9: setIndexAsString = "Ninth"; break;
                    case 10: setIndexAsString = "Tenth"; break;
                }
                Console.WriteLine("{0} set has the most {1} numbers: {2}", setIndexAsString, oddOrEven, maxEvensSetCount);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
