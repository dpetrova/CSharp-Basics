using System;

class StringsAndObjects
{
    static void Main()
    {
        string var1 = "Hello";
        string var2 = "World";
        object concString = var1 + " " + var2;
        string var3 = (string)concString;
        Console.WriteLine(var3);
    }
}
