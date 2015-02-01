using System;

class HalfSum
{
    //You are given a number n and 2*n numbers. Write a program to check whether the sum of the first n numbers 
    //is equal to the sum of the second n numbers. Print as result “Yes” or “No”. In case of yes, print also the sum.
    //In case of no, print also the difference between the left and the right sums.
    //Input
    //The input data should be read from the console.
    //•	The first line holds an integer n – the count of numbers.
    //•	Each of the next 2*n lines holds exactly one number.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //•	The output must be printed on the console.
    //•	Print “Yes, sum=S” where S is the sum of the first n numbers in case of the sum of the first n numbers is equal to the sum of the second n numbers.
    //•	Otherwise print “No, diff=D” where D is the difference between the sum of the first n numbers and the sum of the second n numbers. D should always be a positive number.
    //Constraints
    //•	The number n is integer in range [0...500].
    //•	All other numbers are integers in range [-500 000 ... 500 000].
    //•	Allowed working time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.
    
    static void Main()
    {
        //Console.Write("enter an integer number in range [0...500]:");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[2 * n];
        for (int i = 0; i < 2 * n; i++)
        {
            //Console.WriteLine("enter a number in range [-500 000 ... 500 000]");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int firstHalf = 0;
        int secondHalf = 0;
        for (int i = 0; i < n; i++)
        {
            firstHalf += numbers[i];
        }
        for (int i = n; i < 2 * n; i++)
        {
            secondHalf += numbers[i];
        }
        if (firstHalf == secondHalf)
        {
            Console.WriteLine("Yes, sum={0}", firstHalf);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(firstHalf - secondHalf));
        }
    }
}
