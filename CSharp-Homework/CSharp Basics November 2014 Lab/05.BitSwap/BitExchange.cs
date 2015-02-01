using System;

class BitExchange
{
    //Write a program that reads a number n and exchanges bit 3 with 24.
    //Input
    //The input data is read from the console. 
    //•	The input consists of only 1 line: the number n.
    //•	The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output data must be printed on the console and should consist of only one line – the resulting number.
    //Constraints
    //•	The number n will be an integer number in the range [-9223372036854775808...9223372036854775807]. 
    //•	Time limit: 0.1 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        ulong bit3 = (number >> 3) & 1;
        ulong bit24 = (number >> 24) & 1;
        bit3 = bit3 << 24;
        bit24 = bit24 << 3;
        ulong mask3 = ~((ulong)1 << 3);
        ulong mask24 = ~((ulong)1 << 24);
        number = number & mask3;
        number = number & mask24;
        number = number | bit3;
        number = number | bit24;
        Console.WriteLine(number);
    }
}
