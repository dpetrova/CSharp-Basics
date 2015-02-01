using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name:");
        string companyName = Console.ReadLine();
        Console.Write("Company address:");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number:");
        string companyPhone = Console.ReadLine();
        Console.Write("Fax number:");
        string companyFax = Console.ReadLine();
        Console.Write("Web site:");
        string website = Console.ReadLine();
        Console.Write("Manager first name:");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name:");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age:");
        string managerAge = Console.ReadLine();
        Console.Write("Manager phone:");
        string managerPhone = Console.ReadLine();
        Console.WriteLine("{0} \nAddress: {1} \nTel. {2} \nFax: {3} \nWeb site: {4} \nManager: {5} {6} (age: {7}, tel. {8})", companyName, companyAddress, companyPhone, companyFax, website, managerFirstName, managerLastName, managerAge, managerPhone);
    }
}

