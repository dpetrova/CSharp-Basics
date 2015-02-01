using System;

class BankAccountData
{
    static void Main()
    {
        Console.Write("First name:");
        string firstName = Console.ReadLine();
        Console.Write("Middle name:");
        string middleName = Console.ReadLine();
        Console.Write("Last name:");
        string lastName = Console.ReadLine();
        Console.Write("Balance:");
        decimal Balance = decimal.Parse(Console.ReadLine());
        Console.Write("Bank name:");
        string bankName = Console.ReadLine();
        Console.Write("IBAN:");
        string IBAN = Console.ReadLine();
        Console.Write("Credit card number:");
        ulong cardNumber1 = ulong.Parse(Console.ReadLine());
        Console.Write("Credit card number:");
        ulong cardNumber2 = ulong.Parse(Console.ReadLine());
        Console.Write("Credit card number:");
        ulong cardNumber3 = ulong.Parse(Console.ReadLine());
        Console.Write("Name: {0} {1} {2} \nBalance: {3} \nBank name: {4} \nIBAN {5} \nCredit card: {6}  \nCredit card: {7} \nCredit card: {8}",
                        firstName, middleName, lastName, Balance, bankName, IBAN, cardNumber1, cardNumber2, cardNumber3);
    }
}
