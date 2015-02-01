using System;
using System.Collections.Generic;

class SequenceOfKNumbers
{
    //Write a program to remove all sequences of k equal elements from a sequence of integers. For example, if we have the
    //sequence 3 3 3 8 8 2 5 1 7 7 7 4 4 4 4 3 4 4 and we remove all sequences of k = 2 elements, we will obtain 3 2 5 1 7 3. 
    //For k = 3, we will obtain the following result: 8 8 2 5 1 4 3 4 4. For k = 1, the result will be empty.
    //Input
    //The input data comes from the console. It should consist of a two lines:
    //•	The first line holds the input numbers, separated one from another by a space.
    //•	The second line holds the number k.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. It should consist of a single line holding the obtained sequence of numbers. Separate each number from the next number by a space.
    //Constraints
    //•	The input sequence numbers are integers in the range [-1000 … 1000].
    //•	The count of the input numbers is in the range [1 … 1000].
    //•	The number k is integer in the range [1 … 1000].
    //•	Time limit: 0.1 seconds.
    //•	Memory limit: 16 MB.

    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int k = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        int counter = 1;
        for (int i = 0; i < input.Length; i++)
        {
            numbers.Add(int.Parse(input[i]));
        }
        numbers.Add(int.MaxValue);
        int j = 0;
        if (k == 1)
        {
            numbers.RemoveRange(0, numbers.Count - 1);
        }
        else
        {
            while (j < numbers.Count - 1)
            {
                if (numbers[j] == numbers[j + 1])
                {
                    counter++;
                    if (counter == k)
                    {
                        numbers.RemoveRange(j - (k - 2), k);
                        counter = 1;
                        j = -1;
                    }
                }
                else
                {
                    counter = 1;
                }
                j++;
            }
        }
        numbers.RemoveAt(numbers.Count - 1);

        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}
