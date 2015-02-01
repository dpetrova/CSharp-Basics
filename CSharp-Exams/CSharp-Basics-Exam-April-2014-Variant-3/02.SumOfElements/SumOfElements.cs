using System;
using System.Linq;

class SumOfElements
{
    //You are given n numbers. Find an element that is equal to the sum of all of the other elements.
    //Input
    //Input data should be read from the console.
    //•	At the only line in the input a sequence of integers stays (numbers separated one from another by a space).
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output data must be printed on the console. At the only line of the output print the result.
    //•	Print "Yes, sum=…" if there is an element that is equal to the sum of all other elements, along with this sum.
    //•	Print "No, diff=…" if there is no element that is equal to the sum of all other elements. Print also the minimum
    //possible difference between an element from the sequence and the sum of all other elements (always a positive number).
    //Constraints
    //•	All input numbers are integers in the range [0 … 2 000 000 000].
    //•	The count n of the input integers is in the range [2 ... 1 000].
    //•	Allowed working time for your program: 0.1 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        string[] str = Console.ReadLine().Split();
        int[] numbers = new int[str.Length];
        long sumOfAll = 0;
        for (int i = 0; i < str.Length; i++)
        {
            numbers[i] = int.Parse(str[i]);
            sumOfAll = sumOfAll + numbers[i];
        }
        int maxNumber = numbers.Max();
        if (maxNumber == (sumOfAll - maxNumber)) //if such number exists, it will always be the maximum number in the array (sumOfAll == 2*maxNumber)
        {
            Console.WriteLine("Yes, sum={0}", maxNumber);
        }
        else
        {
            long diff = Math.Abs(maxNumber - (sumOfAll-maxNumber)); //sumOfAll - 2*maxNumber
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}
