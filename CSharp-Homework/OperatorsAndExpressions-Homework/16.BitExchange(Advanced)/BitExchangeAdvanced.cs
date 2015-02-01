using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        uint number;
        byte p, q, k;
        Console.Write("unsigned integer number:");
        bool isNumberUint = uint.TryParse(Console.ReadLine(), out number);
        Console.Write("initial position of first sequence p:");
        bool isPByte = byte.TryParse(Console.ReadLine(), out p);
        Console.Write("inital position of second sequence q:");
        bool isQByte = byte.TryParse(Console.ReadLine(), out q);
        Console.Write("number of bits k:");
        bool isKByte = byte.TryParse(Console.ReadLine(), out k);
        if (isNumberUint && isPByte && isQByte && isKByte)
        {
            if ((p < q && p + k > q) || (q < p && q + k > p))
            {
                Console.WriteLine("overlapping");
                return;
            }
            else if (p + k > 32 || q + k > 32)
            {
                Console.WriteLine("out of range");
                return;
            }
            else
            {
                Console.WriteLine("binary represantation of initial number: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
                for (int i = 0; i < k; i++)
                {
                    uint shiftRightp = number >> (p + i); // shift bits p, p+1,...p+k-1 to the right
                    uint shiftRightq = number >> (q + i); // shift bits q, q+1,...q+k-1 to the right
                    uint bitsp = shiftRightp & 1; // gets the bits only (0 or 1)
                    uint bitsq = shiftRightq & 1; // gets the bits only (0 or 1)
                    uint shiftLeftp = bitsp << (q + i); // shift bit 3 (,4,5) to positon 24 (,25,26) (exchange their positions)
                    uint shiftLeftq = bitsq << (p + i); // shift bit 24 (,25,26) to position 3 (,4,5) (exchange their positions)
                    // to set to zero bits in the initial number
                    uint maskp = (uint)~(1 << (p + i));
                    uint maskq = (uint)~(1 << (q + i));
                    number = number & maskp; // set bit 3 (,4,5) to zero in the initial number
                    number = number & maskq; // set bit 24 (,25,26) to zero in the initial number
                    number = number | shiftLeftq; //set zeroes with exchanged before shiftLeftq
                    number = number | shiftLeftp; //set zeroes with exchanged before shiftLeftp
                }
                Console.WriteLine("result = {0}", number);
                Console.WriteLine("binary represantation of result: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
            }
        }
        else
        {
            Console.WriteLine("out of range");
            return;
        }
    }
}
