using System;
using System.Collections.Generic;

class RandomizeTheNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i); //add numbers from 1 to n in the List
        }
        Random rand = new Random();
        List<int> shuffledNumbers = new List<int>();
        while (numbers.Count > 0) //at every one iteration one element of numbers is removed, until numbers.Count = 0
        {
            int i = rand.Next(numbers.Count); //generates non-negative random number from 0 to numbers.Count
            shuffledNumbers.Add(numbers[i]); // add in List "shuffledNumbers" the number at position [i] from List numbers
            numbers.RemoveAt(i); //remove from List "numbers" the element at position [i]
        }
        Console.WriteLine(String.Join(" ", shuffledNumbers));
    }
}
