using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? var1 = null;
        double? var2 = null;
        Console.WriteLine(var1.HasValue);
        Console.WriteLine(var2.HasValue);
        Console.WriteLine("var1 = {0} \nvar2 = {1}", var1, var2);
        Console.WriteLine("var1 + 5 =", var1 + 5);
        Console.WriteLine("var1 + var2 =", var1 + var2);
    }
}
