using System;

class QuotesInStrings
{
    static void Main()
    {
        string str1 = "The \"use\" of quotations causes difficulties.";
        string str2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("{0} \n{1}", str1, str2);    
    }
}
