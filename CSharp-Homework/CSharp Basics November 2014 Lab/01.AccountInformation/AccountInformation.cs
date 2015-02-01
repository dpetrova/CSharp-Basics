using System;

class AccountInformation
{
    //Write a program that reads a first name, last name, client id and account balance, and prints a text with that 
    //information on the console.
    //Input
    //The input data is read from the console. 
    //•	The input consists of 4 lines:
    //o	On the first line you will receive the first name
    //o	On the second line you will receive the last name
    //o	On the third line you will receive the client id
    //o	On the last line you will receive the total account balance
    //•	The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output data must be printed on the console in following format:
    //Hello, <first name> <last name>
    //Client id: <id>
    //Total balance: <account balance>
    //Active: <yes/no>
    //The account balance should be rounded to 2 digits after the decimal separator. Print "yes" if the balance is greater
    //or equal to 0, and "no" if it is negative. 
    //Constraints
    //•	The client id will be an integer number in the range [0…2 147 483 647].
    //•	Time limit: 0.1 seconds.
    //•	Allowed memory: 16 MB.
    
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int IDNumber = int.Parse(Console.ReadLine());
        decimal totalBalance = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Hello, {0} {1}", firstName, lastName);
        Console.WriteLine("Client id: " + IDNumber);
        Console.WriteLine("Total balance: {0:0.00}", totalBalance);
        if (totalBalance >= 0)
        {
            Console.WriteLine("Active: yes");
        }
        else
        {
            Console.WriteLine("Active: no");
        }
    }
}
