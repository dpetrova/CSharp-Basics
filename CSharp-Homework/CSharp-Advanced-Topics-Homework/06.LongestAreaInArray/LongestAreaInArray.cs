using System;

class LongestAreaInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] str = new string[n];
        for (int i = 0; i < str.Length; i++)
        {
            str[i] = Console.ReadLine();
        }
        int maxLength = 1;
        string maxElement = str[0];
        int count = 1;
        string currentStr = str[0];
        for (int i = 1; i < str.Length; i++)
        {
            if (currentStr == str[i])
            {
                count++;
            }
            else
            {
                currentStr = str[i];
                count = 1;
            }
            if (count > maxLength)
            {
                maxLength = count;
                maxElement = currentStr;
            }
        }
        Console.WriteLine(maxLength);
        for (int i = 0; i < maxLength; i++)
        {
            Console.WriteLine(maxElement);
        }

    }
}

