using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: \n1 --> int \n2 --> double \n3 --> string");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Console.WriteLine("Please enter an integer:");
                int number1 = int.Parse(Console.ReadLine());
                number1++;
                Console.WriteLine(number1);
                break;
            case "2":
                Console.WriteLine("Please enter a double:");
                double number2 = double.Parse(Console.ReadLine());
                number2++;
                Console.WriteLine(number2);
                break;
            case "3":
                Console.WriteLine("Please enter a string:");
                string str = Console.ReadLine();
                Console.WriteLine(str + "*");
                break;
        }
    }
}
