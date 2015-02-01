using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Enter a weight:");
        double earthWeight = double.Parse(Console.ReadLine());
        double moonWeight = earthWeight * 0.17;
        Console.WriteLine("This weight on the moon will be {0}", moonWeight);       
    }
}
