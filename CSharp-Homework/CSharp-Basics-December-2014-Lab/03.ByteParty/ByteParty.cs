using System;

class ByteParty
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] numbers = new int[N];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(numbers[i], 2));
        }
        string input = Console.ReadLine();
        while (input != "party over")
        {
            string[] commands = input.Split();
            string action = commands[0];
            int position = int.Parse(commands[1]);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (action == "-1")
                {
                    numbers[i] ^= 1 << position;
                }
                else if (action == "0")
                {
                    numbers[i] &= ~(1 << position);

                }
                else if (action == "1")
                {
                    numbers[i] |= 1 << position;
                }
                //Console.WriteLine(Convert.ToString(numbers[i], 2));
            }
            
            input = Console.ReadLine();
        }
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
