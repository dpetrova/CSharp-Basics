using System;
using System.Collections.Generic;

class LargestProductOfDigits
{
    //You are given an integer number. Your task is to find the largest product of six consecutive digits of that number
    //and print it on the console. E.g., in the number 1111110 the product of the first six digits is 1 (1*1*1*1*1*1 = 1) 
    //and the product of the last six digits is 0 (1*1*1*1*1*0 = 0), therefore, the output should be 1.
    //Input
    //•	The input data is read from the console. 
    //•	On the only input line you will be given an integer number.
    //•	The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //•	The output data must be printed on the console.
    //•	On the only output line you must print the largest product of six consecutive digits found in the input number.
    //Constraints
    //•	The number of digits of the input number will be in the range [6 … 1000].
    //•	Time limit: 0.25 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        string number = Console.ReadLine();
        int[] digits = new int[number.Length];
        int maxProduct = 0;
        int product = 0;
        for (int i = 0; i < number.Length; i++)
        {
            digits[i] = int.Parse("" + number[i]);
        }
        for (int i = 0; i < digits.Length - 5; i++)
        {
            product = digits[i] * digits[i + 1] * digits[i + 2] * digits[i + 3] * digits[i + 4] * digits[i + 5];
            if (product >= maxProduct)
            {
                maxProduct = product;
            }
        }
        Console.WriteLine(maxProduct);
    }
}
