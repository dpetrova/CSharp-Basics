using System;

class BitSifting
{
    //In this problem we'll be sifting bits through sieves (sift = пресявам, sieve = сито).
    //You will be given an integer, representing the bits to sieve, and several more numbers, representing the sieves the bits will
    //fall through. Your task is to follow the bits as they fall down, and determine what comes out of the other end.
    //Example
    //For this example, imagine we are working with 8-bit integers (the actual problem uses 64-bit ones). 
    //Let the initial bits be given as 165 (10100101 in binary), and the sieves be 138 (10001010), 84 (01010100) and 154 (10011010).
    //The 1 bits from the initial number fall through the 0 bits of the sieves and stop if they reach a 1 bit; if they make it
    //to the end, they become a part of the final number.
    //In this case, the final number is 33 (00100001), which has two 1 bits in its binary form – the answer is 2.	10100101
    //    10100101
    //    ↓ ↓  ↓ ↓
    //    10001010
    //      ↓  ↓ ↓
    //    01010100
    //      ↓    ↓
    //    10011010
    //      ↓    ↓
    //    00100001
    //Input
    //The input data should be read from the console.
    //•	On the first line of input, you will read an integer representing the bits to sieve.
    //•	On the second line of input, you will read an integer N representing the number of sieves.
    //•	On the next N lines of input, you will read N integers representing the sieves.
    //The input data will always be valid and in the format described. There is no need to check it.
    //Output
    //The output must be printed on the console.
    //On the single line of the output you must print the count of "1" bits in the final result.
    //Constraints
    //•	All numbers in the input will be between 0 and 18,446,744,073,709,551,615.
    //•	The count of sieves N is in range [0…100].
    //•	Allowed work time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        ulong bitsToSieve = ulong.Parse(Console.ReadLine());
        byte numberOfSieves = byte.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfSieves; i++)
        {
            ulong sieve = ulong.Parse(Console.ReadLine());
            bitsToSieve = bitsToSieve & (~sieve); //като се направи маска на ситото (инвертиране на битовете), 0 стават 1,
                                                 //а 1 стават 0. Където преди е било 0, т.е. да минава, сега е 1 и ако bitsToSieve е
                                                 //1, то 1 & 1 = 1, т.е. бита преминава. Ако ситото е било 1, т.е да стопира, 
                                                //сега ще е 0, и следователно 1 & 0 = 0, т.е. бита се стопира.
        }
        ulong bitsCount = 0;
        while (bitsToSieve > 0)
        {
            bitsCount += (bitsToSieve & 1); //1 е 00000001 в бинарен вид, и 1 & bitsToSieve ще покаже какъв е първия бит
                                            //(от дясно наляво); ако даде 1, значи бита е 1, ако даде 0, значи бита е 0
            bitsToSieve = bitsToSieve >> 1; //отмествайки постепенно в дясно с по една позиция, ще се проверят какви са и 
                                            //останалите битове (като станат на първа позиция)
        }
        Console.WriteLine(bitsCount);
    }
}
