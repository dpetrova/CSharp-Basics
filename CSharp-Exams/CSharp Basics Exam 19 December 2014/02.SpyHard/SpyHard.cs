using System;
using System.Text;
using System.Numerics;

class SpyHard
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string message = input.ToLower();
        int sum = 0;
        for (int i = 0; i < message.Length; i++)
        {
            if (Char.IsLetter(message[i]))
            {
                sum += message[i] % 96;
            }
            else
            {
                sum += message[i];
            }
        }
        string sumAsString = null;
        int residue;
        while (sum > 0)
        {
            residue = sum % key;
            sum = sum / key;
            sumAsString = residue.ToString() + sumAsString;
        }
                 
        //string sumAsString = Encode(sum, key);
        string result = "" + key + input.Length + sumAsString;
        Console.WriteLine(result);
    }


    //public static string Encode(BigInteger value, int @base = 0, string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ")
    //{
    //    if (@base <= 0) @base = chars.Length;
    //    var sb = new StringBuilder();
    //    do
    //    {
    //        int m = (int)(value % @base);
    //        sb.Insert(0, chars[m]);
    //        value = (value - m) / @base;
    //    } while (value > 0);
    //    return sb.ToString();
    //}

}
