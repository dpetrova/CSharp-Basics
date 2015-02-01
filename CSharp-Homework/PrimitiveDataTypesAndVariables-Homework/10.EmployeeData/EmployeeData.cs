using System;

class EmployeeData
{
    static void Main()
    {
        Console.Write("First Name:");
        string FirstName = Console.ReadLine();
        Console.Write("Last Name:");
        string LastName = Console.ReadLine();
        Console.Write("Age:");
        byte Age = byte.Parse(Console.ReadLine());
        Console.Write("Gender(M or F):");
        char Gender = char.Parse(Console.ReadLine());
        Console.Write("ID Number:");
        ulong IDNumber = ulong.Parse(Console.ReadLine());
        Console.Write("Employee Number:");
        uint EmployeeNumber = uint.Parse(Console.ReadLine());
        Console.WriteLine("Name: {0} {1} \nAge:{2} \nGender:{3} \nID Number:{4} \nEmployee Number:{5}",
                                                        FirstName, LastName, Age, Gender, IDNumber, EmployeeNumber);
    }
}
