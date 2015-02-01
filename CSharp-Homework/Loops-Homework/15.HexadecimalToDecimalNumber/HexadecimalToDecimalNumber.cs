using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("enter a hexadecimal number:");
        string hexNum = Console.ReadLine();
        char[] hex = hexNum.ToCharArray();
        int num = 0;
        long decNum = 0L;
        for (int i = 0; i < hex.Length; i++)
        {
            switch (hex[i])
            {
                case '0':
                    num = 0;
                    break;
                case '1':
                    num = 1;
                    break;
                case '2':
                    num = 2;
                    break;
                case '3':
                    num = 3;
                    break;
                case '4':
                    num = 4;
                    break;
                case '5':
                    num = 5;
                    break;
                case '6':
                    num = 6;
                    break;
                case '7':
                    num = 7;
                    break;
                case '8':
                    num = 8;
                    break;
                case '9':
                    num = 9;
                    break;
                case 'A':
                case 'a':
                    num = 10;
                    break;
                case 'B':
                case 'b':
                    num = 11;
                    break;
                case 'C':
                case 'c':
                    num = 12;
                    break;
                case 'D':
                case 'd':
                    num = 13;
                    break;
                case 'E':
                case 'e':
                    num = 14;
                    break;
                case 'F':
                case 'f':
                    num = 15;
                    break;
            }
            decNum = decNum + num * (long)Math.Pow(16, hex.Length - 1 - i);
        }
        Console.WriteLine(decNum);
    }
}
