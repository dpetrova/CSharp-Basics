using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long dec = long.Parse(Console.ReadLine());
        long? residue = null;
        string hex = null;
        while (dec > 0)
        {
            residue = dec % 16;
            switch (residue)
            {
                case 10:
                    hex = 'A' + hex;
                    break;
                case 11:
                    hex = 'B' + hex;
                    break;
                case 12:
                    hex = 'C' + hex;
                    break;
                case 13:
                    hex = 'D' + hex;
                    break;
                case 14:
                    hex = 'E' + hex;
                    break;
                case 15:
                    hex = 'F' + hex;
                    break;
                default:
                    hex = residue.ToString() + hex;
                    break;
            }
            dec /= 16;
        }
        Console.WriteLine(hex);
    }
}
