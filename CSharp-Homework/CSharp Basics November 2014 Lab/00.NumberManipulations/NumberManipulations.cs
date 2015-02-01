using System;
using System.Collections.Generic;

class NumberManipulations
{
    //Read a number n from the console and perform the following operations with it.
    
    //Step 1 
    //Print the last digit of n.

    //Step 2 
    //Print the last 3 digits of n. If the number has less than 3 digits, print all of them.

    //Step 3
    //Print the the p-th digit of n counted from right to left.

    //Step 4
    //Print all digits separated by dash '-' lines.

    //Step 5
    //Print how many digits n has.

    //Step 6
    //Reverse and print the digits of n.

    //Step 7
    //Print the sum of all digits of n.

    //Step 8
    //Split n in half. Print both halves on separate lines. If the number has odd length of it's digits:

    //Step 9
    //Find whether the first or the second half has a bigger sum. 
    //Examples:
    //•	1245 – first half has sum 1+2=3 and second half has sum 4+5=9. Print "second half is greater".
    //•	3621 – first half has sum 3+6=9 and second half has sum 2+1=3. Print "first half is greater".
    //•	5739 - first half has sum 5+7=12 and the second half has sum 3+9=12. Print "equal".

    //Step 10 
    //Find the product of all even and all odd digits of the number.
    //Example: n = 431847
    //•	Even numbers have product 4*8*4=128
    //•	Odd numbers have product 3*1*7=21 

    static void Main()
    {
        //step 1
        int number = int.Parse(Console.ReadLine());
        //int lastDigit = number % 10;
        //Console.WriteLine(lastDigit);

        //step2
        //int last3Digits = number % 1000;
        //Console.WriteLine(last3Digits);

        //step3
        //int position = int.Parse(Console.ReadLine());
        //for (int i = 0; i < position - 1; i++)
        //{
        //    number = number / 10;
        //}
        //int pDigit = number % 10;
        //Console.WriteLine(pDigit);

        //по-хитър начин:
        //number = number / (int)(Math.Pow(10, position - 1));
        //int pDigit = number % 10;
        //Console.WriteLine(pDigit);

        //step4
        string numAsString = Convert.ToString(number);
        for (int i = 0; i < numAsString.Length; i++)
        {
            bool lastSymbol = i < numAsString.Length - 1;
            Console.Write("" + numAsString[i] + (lastSymbol? '-':' '));
        }
        Console.WriteLine();
                
        //step5
        //Console.WriteLine(numAsString.Length);

        //step6
        //for (int i = numAsString.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(numAsString[i]);
        //}

        //step7
        //int sum = 0;
        //while (number > 0)
        //{
        //    int digit = number % 10;
        //    sum += digit;
        //    number /= 10;
        //}
        //Console.WriteLine(sum);

        //step8
        //string firstHalf = null;
        //string secondHalf = null;
        //if (numAsString.Length % 2 == 0)
        //{
        //    firstHalf = numAsString.Substring(0, numAsString.Length / 2);
        //    secondHalf = numAsString.Substring(0 + numAsString.Length / 2, numAsString.Length / 2);
        //}
        //else
        //{
        //    firstHalf = numAsString.Substring(0, numAsString.Length / 2 + 1);
        //    secondHalf = numAsString.Substring(0 + numAsString.Length / 2 + 1, numAsString.Length / 2);
        //}
        //Console.WriteLine(firstHalf);
        //Console.WriteLine(secondHalf);

        //step9
        //int half1 = Convert.ToUInt16(firstHalf);
        //int half2 = Convert.ToUInt16(secondHalf);
        //int sum1 = 0;
        //int sum2 = 0;
        //while (half1 > 0)
        //{
        //    int digit = half1 % 10;
        //    sum1 += digit;
        //    half1 /= 10;
        //}
        //while (half2 > 0)
        //{
        //    int digit = half2 % 10;
        //    sum2 += digit;
        //    half2 /= 10;
        //}
        //if (sum1 > sum2)
        //{
        //    Console.WriteLine("first half is greater");
        //}
        //else if (sum2 > sum1)
        //{
        //    Console.WriteLine("second half is greater");
        //}
        //else
        //{
        //    Console.WriteLine("equal");
        //}

        //step10
        //string number = Console.ReadLine();
        //List<int> digits = new List<int>();
        //for (int i = 0; i < number.Length; i++)
        //{
        //    digits.Add(int.Parse("" + number[i]));
        //}
        //int oddProduct = 1;
        //int evenProduct = 1;
        //for (int i = 0; i < digits.Count; i++)
        //{
        //    if (digits[i] % 2 == 0)
        //    {
        //        oddProduct *= digits[i];
        //    }
        //    else
        //    {
        //        evenProduct *= digits[i];
        //    }
        //}
        //Console.WriteLine("Odd product: " + oddProduct);
        //Console.WriteLine("Even product: " + evenProduct);
    }
}
