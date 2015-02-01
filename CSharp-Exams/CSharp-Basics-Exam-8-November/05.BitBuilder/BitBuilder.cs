using System;

class BitBuilder
{
    //Pesho is a nasty little brat who likes to do mischiefs all the time. You are given the task to keep him busy and thus
    //have come up with a game you named Bit Builder. The rules of the game are as follows:
    //You are given a sequence of bits (an integer number) and Pesho chooses a position and issues an order in order to 
    //manipulate the given bit. If he says flip, you have to reverse the value of the bit. For example if the bit’s value
    //is 1, it has to become 0. If Pesho’s order is remove, you have to remove the bit from the bit sequence 
    //(1 1100 1101  0 1110 0101). However, if he issues the order insert the bit 1 has to be inserted in the wanted 
    //position (0 1110 0101  1 1100 1101). If he issues the order skip, you don’t have to do anything with the given bit.
    //Whenever Pesho says quit, the game ends.
    //Input
    //The input data should be read from the console. On the first line, you are given an integer number and on each of the
    //next two lines, you have a bit position and an issued order.
    //The possible orders are as follows: “flip”, “remove”, “insert”, “skip”. On the last input line, you are given the 
    //order “quit”, which means that the game has ended.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //On the only output line print the bits of the number after the end of the game 
    //Constraints
    //•	The input number will be a 32-bit integer in the range [0 … 2 147 483 647].
    //•	The position will be in the range [0 … 31].
    //•	The maximum number of commands will be 30.
    //•	Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        byte position;
        string command;
        while (true)
        {
            bool isPosition = byte.TryParse(Console.ReadLine(), out position);
            if (!isPosition)
            {
                break;
            }
            else
            {
                command = Console.ReadLine();
            }

            // 2 начина да направи маска от 1-ци в двоична бройна с-ма, без предварително да знае колко са (в случая са position  на брой)
            long mask = 0L;
            //1-ви начин    
            //string binaryMask = new string('1', position);
            //if (position != 0)
            //{
            //    mask = Convert.ToInt64(binaryMask, 2);
            //}

            //2-ри начин
            for (int i = 0; i < position; i++)
            {
                mask <<= 1;
                mask |= 1;
            }

            long rightBits = mask & number; //запазваме десните битове (от position надясно)

            switch (command)
            {
                case "flip":
                    number = number ^ ((long)1 << position);
                    break;
                case "remove":
                    number >>= (position + 1); //number = number >> (position + 1) //премествам го на дясно, за да махна десните битове + бита на позиция position
                    number <<= position; //number = number << position; //връщам го наляво като се прави място за добавяне на махнатите десни битове
                    number |= rightBits; //number = number | rightBits; //връщам десните битове
                    break;
                case "insert":
                    number >>= position; // премествам го на дясно, за да махна десните битове преди позицията, където трябва да вмъкна 1
                    number <<= position + 1; //връщам го наляво с една позиция повече, за да направя място за десните битове и 1-та, която трябва да се вмъкне
                    number |= ((long)1 << position); //вмъквам 1-ца
                    number |= rightBits; //връщам десните битове
                    break;
                case "skip":
                    break;
            }
        }
        Console.WriteLine(number);
    }
}
