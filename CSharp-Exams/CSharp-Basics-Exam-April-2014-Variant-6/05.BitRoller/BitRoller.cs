using System;

class BitRoller
{
    //Nakov enjoys playing with bits very much. Yesterday he invented a new game. He takes a 19-bit number and rolls it
    //on the right (moves its most right bit at the left most position). He tried this several times and he found it is too easy.
    //Then he invented a more complex game: freeze a certain bit as a pillar and roll right all other bits several times. 
    //Now he is happy but he wants to automate this process.
    //Help Nakov to write a program that rolls r times a 19-bit number n with a frozen bit at position f.
    //Example: we have the number n = 2521, which is 0000000100111011001 in binary (as a 19-bit number). 
    //We freeze the bit at position f = 8 (we count the positions from the right, starting from 0). 
    //We roll out the number r = 4 times. We obtain the result 295245 as follows:
    //•	2521(10) = 0000000100111011001 -> 1000000010101101100 (roll right with frozen position 8)
    //•	1000000010101101100 -> 0100000001100110110 (roll right with frozen position 8)
    //•	0100000001100110110 -> 0010000000110011011 (roll right with frozen position 8)
    //•	0010000000110011011 -> 1001000000101001101 = 295245(10) (roll right with frozen position 8)
    //Input
    //The input data should be read from the console. It will consist of 3 lines:
    //•	The number n stays at the first line.
    //•	The number f stays at the second line.
    //•	The number r stays at the third line.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //Print the obtained result after rolling r times n with a frozen bit at position f at the console (as decimal number).
    //Constraints
    //•	The number n will be a 19-bit unsigned integer (in the range [0…524287]).
    //•	The number f will be integer in the range [0…18].
    //•	The number r will be integer in the range [0…100].
    //•	Allowed working time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(19, '0'));
        byte f = byte.Parse(Console.ReadLine());
        byte r = byte.Parse(Console.ReadLine());
        for (int i = 0; i < r; i++)
        {
            int firstBit = 1 & n; // get the first bit
            if (f == 18) //if freezed number is in the last position (18)
            {
                firstBit = firstBit << 17; // move the first bit to the most left before freezed bit
            }
            else if (f == 0) //if freezed bit is on the first position
            {
                firstBit = (n >> 1) & 1; // it is actually the second bit
                firstBit = firstBit << 18;
            }
            else
            {
                firstBit = firstBit << 18; // move the first bit to the most left on the last position
            }

            if (f == 0)
            {
                int shiftFreezedBit = n >> f;
                int freezedBit = shiftFreezedBit & 1;
                n = n >> 1; //roll number one position right
                n = n | freezedBit;
                n = n | firstBit; //add first bit at the last position in the number
                //Console.WriteLine(Convert.ToString(n, 2).PadLeft(19, '0'));
            }
            else
            {
                n = n >> 1; //roll number one position right

                //exchange bits at positions f and f-1
                int shiftPreviousBit = n >> (f - 1);
                int previousBit = shiftPreviousBit & 1;
                int shiftFreezedBit = n >> f;
                int freezedBit = shiftFreezedBit & 1;
                previousBit = previousBit << f;
                freezedBit = freezedBit << f - 1;
                int maskBit = (int)~(1 << f - 1);
                n = n & maskBit;
                int maskPreviousBit = (int)~(1 << f);
                n = n & maskPreviousBit;
                n = n | previousBit;
                n = n | freezedBit;
                n = n | firstBit; //add first bit at the last position in the number
                //Console.WriteLine(Convert.ToString(n, 2).PadLeft(19, '0'));
            }
        }
        Console.WriteLine(n);
    }
}
