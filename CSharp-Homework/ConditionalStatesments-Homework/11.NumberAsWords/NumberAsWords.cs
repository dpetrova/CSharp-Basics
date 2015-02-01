using System;

class NumberAsWords
{
    static void Main()
    {
        Console.Write("enter a integer number in the range [0…999]:");
        int number = int.Parse(Console.ReadLine());
        string str = null;
        string[] units = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
        string[] teens = {"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = { null, "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        if (number >= 0 && number <= 10)
	    {
		    str = units[number];
	    }
        else if (number >= 11 && number <= 19)
        {
            int n2 = number % 10;
            str = teens[n2];
        }
        else if (number >= 20 && number <= 99)
        {
            int n1 = number / 10; //first digit
            int n2 = number % 10; //second digit
            str = tens[n1] + " " + units[n2];
        }
        else if (number >= 100 && number <= 999)
        {
            int n1 = number / 100; //first digit
            int n2 = (number / 10) % 10; //second digit
            int n3 = number % 10; //third digit
            if (n2 == 0 && n3 == 0)
            {
                str = units[n1] + " " + "hundred";
            }
            else if (n2 == 0)
            {
                str = units[n1] + " " + "hundred and" + " " + units[n3];
            }
            else if (n3 == 0)
            {
                str = units[n1] + " " + "hundred and" + " " + tens[n2];
            }
            else if (n2 == 1) 
            {
                str = units[n1] + " " + "hundred and" + " " + teens[n3];
            }
            else
            {
                str = units[n1] + " " + "hundred and" + " " + tens[n2] + " " + units[n3];
            }
        }
        else
        {
            Console.WriteLine("invalid range");
        }
        Console.WriteLine(str);
    }
}
