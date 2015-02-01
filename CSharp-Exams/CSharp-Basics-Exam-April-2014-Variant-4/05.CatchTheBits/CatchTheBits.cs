using System;

class CatchTheBits
{
    //You are given a sequence of bytes. Consider each byte as sequence of exactly 8 bits.  You are given also a number step. 
    //Write a program to extract all the bits at positions: 1, 1 + step, 1 + 2*step, ... Print the output as a sequence of bytes.
    //In case the last byte have less than 8 bits, add trailing zeroes at its right end. 
    //Bits in each byte are counted from the leftmost to the rightmost. Bits are numbered starting from 0.
    //Input
    //•	The input data should be read from the console.
    //•	The number n stays at the first line.
    //•	The number step stays at the second line.
    //•	At each of the next n lines n bytes are given, each at a separate line. 
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. Print the output bytes, each at a separate line.
    //Constraints
    //•	The number n will be an integer number in the range [1…100].
    //•	The number step will be an integer number in the range [1…20].
    //•	The n numbers will be integers in the range [0…255].
    //•	Allowed working time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;
        int digit = 0;
        string newNumber = null;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int bit = 7; bit >= 0; bit--)
            {
                if (step == 1 || index % step == 1)
                {
                    digit = 1 & number >> bit;
                    newNumber += digit;
                }
                index++;
            }
        }
        if (newNumber.Length < 8)
        {
            newNumber = newNumber.PadRight(8, '0');
            int output = Convert.ToInt32(newNumber, 2);
            Console.WriteLine(output);
        }
        else if (newNumber.Length > 8 && newNumber.Length < 16)
        {
            newNumber = newNumber.PadRight(16, '0');
            string[] nums = newNumber.Split(2);
            string newNumber1 = newNumber.Remove(8);
            string newNumber2 = newNumber.Remove(0,1,2,3,4,5,6,7);
            int ouput1 = Convert.ToInt32(newNumber1, 2);
            int ouput2 = Convert.ToInt32(newNumber2, 2);
            Console.WriteLine("{0} \n{1}", ouput1, ouput2);
        }
    }
}
