using System;

class BitShooter
{
    //We are given a bit field in the form of 64-bit integer number. We shoot it 3 times. Each shoot has a center and a size.
    //The shoot damages size bits around the shoot center (makes these bits 0). Finally, the bit field is split into left side
    //(bits 63 … 32) and right side (bits 31 … 0). Write a program that calculates how many bits survive (have value 1) after
    //the shoots in the left side and in the right side of the bit field. The bits are numbered as traditionally in programming:
    //from right to left from 0 to 63. Note that if we shoot at the bit field border (e.g. center=63 and size=15),
    //the damage is partial because some damaged bits are outside of the bit field.
    //Input
    //The input data should be read from the console. It will consist of exactly 4 lines:
    //•	At the first line you will have a 64-bit integer, corresponding to the bit field.
    //•	At each of the next 3 lines we have 2 numbers: shoot center and shoot size – integers, split by a space.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. It should consists of exactly 2 lines:
    //•	The first line print "left: …" and the number of alive bits in the left side.
    //•	The second line print "right: …" and the number of alive bits in the right side.
    //Constraints
    //•	The bit field will be a 64-bit integer in the range [0 … 18 446 744 073 709 551 615].
    //•	The values for the center will be integers will be integers in range [0 … 63].
    //•	The values for the size will be odd integers in range [1 … 99].
    //•	Allowed working time for your program: 0.25 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString((Int64)number, 2).PadLeft(64, '0'));
        for (int i = 0; i < 3; i++)
        {
            string[] shoot = Console.ReadLine().Split();
            sbyte shootCenter = sbyte.Parse(shoot[0]);
            sbyte shootSize = sbyte.Parse(shoot[1]);
            sbyte startPosition = (sbyte)(shootCenter - (shootSize / 2));
            if (startPosition < 0)
            {
                startPosition = 0;
            }
            sbyte endPosition = (sbyte)(shootCenter + (shootSize / 2));
            if (endPosition > 63)
            {
                endPosition = 63;
            }
            for (sbyte j = startPosition; j <= endPosition; j++)
            {
                ulong mask = ~((ulong)1 << j);
                number = number & mask;
            }
            //Console.WriteLine(Convert.ToString((Int64)number, 2).PadLeft(64, '0'));
        }
        string num = Convert.ToString((Int64)number, 2).PadLeft(64, '0');
        string numLeft = num.Substring(0, 32);
        string numRight = num.Substring(32, 32);
        int countLeft = 0;
        int countRight = 0;
        foreach (var digit in numLeft)
        {
            if (digit == '1')
            {
                countLeft++;
            }
        }
        foreach (var digit in numRight)
        {
            if (digit == '1')
            {
                countRight++;
            }
        }
        Console.WriteLine("left: " + countLeft);
        Console.WriteLine("right: " + countRight);
    }
}
