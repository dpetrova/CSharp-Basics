using System;

class WeAllLoveBits
{
    //Mitko is a "bitwise guy". He invented a new bitwise algorithm. The algorithm takes one positive integer number P, 
    //makes magic with it and returns a new positive integer number. He also defined a new number Q which represents 
    //the number P in binary numeral system with inverted bits. All zeros in P are ones in Q and all ones in P are zeros in Q.
    //For example if we have P = 9 (which is 1001 in binary numeral system) its inverted number Q will be equal to 6 (which 
    //is 110 in binary numeral system). But that’s not all! He invented another number R, which represents reversed number P
    //in binary numeral system. For example if we have P = 11 (which is 1011 in binary numeral system) its reversed 
    //number R is equal to 13 (which is 1101 in binary numeral system). The Mitko's magical algorithm takes a number P and
    //transforms it to a new number Pnew using the following bitwise transformation: Pnew = (P ^ Q) & R.
    //Your task is to write a program that transforms a sequence of N positive integer numbers using Mitko's algorithm.
    //Input
    //•	The input data should be read from the console.
    //•	At the first input line there will be one positive integer – the number N.
    //•	At each of the next N lines there will be one positive integer – the consequent number that must be converted using Mitko's algorithm.
    //•	The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //•	The output data should be printed on the console.
    //•	The output must consist of N lines, containing the transformed numbers for each number from the input.
    //Constraints
    //•	The number N will be positive integer number between 1 and 20 000, inclusive.
    //•	Each of the N numbers will be positive integer numbers between 1 and 2 147 483 647, inclusive.
    //•	Time limit: 0.20 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            int P = int.Parse(Console.ReadLine());
            string PAsString = Convert.ToString(P, 2);
            //Console.WriteLine(PAsString);
            char[] PAsCharArr = PAsString.ToCharArray();
            char[] QAsCharArr = new char[PAsCharArr.Length];
            for (int j = 0; j < QAsCharArr.Length; j++)
            {
                if (PAsCharArr[j] == '0')
                {
                    QAsCharArr[j] = '1';
                }
                else
                {
                    QAsCharArr[j] = '0';
                }
            }
            //Console.WriteLine(new string(QAsCharArr));
            int Q = Convert.ToInt32(new string(QAsCharArr), 2);
            //Console.WriteLine(Q);
            char[] RAsCharArr = new char[PAsCharArr.Length];
            for (int k = 0; k < RAsCharArr.Length; k++)
            {
                RAsCharArr[k] = PAsCharArr[(PAsCharArr.Length -1) - k];
            }
            //Console.WriteLine(new string(RAsCharArr));
            int R = Convert.ToInt32(new string(RAsCharArr), 2);
            //Console.WriteLine(R);
            int Pnew = (P ^ Q) & R;
            Console.WriteLine(Pnew);
        }
    }
}
