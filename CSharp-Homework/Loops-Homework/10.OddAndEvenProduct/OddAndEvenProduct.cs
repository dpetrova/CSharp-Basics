using System;

class OddAndEvenProduct
{
    static void Main()
    {
        string[] str = Console.ReadLine().Split();
        int[] num = new int[str.Length];
        decimal oddProd = 1;
        decimal evenProd = 1;
        for (int i = 0; i < str.Length; i++)
        {
            num[i] = int.Parse(str[i]);
            if (i % 2 == 0)
            {
                oddProd *= num[i];
            }
            else
            {
                evenProd *= num[i];
            }
        }
        if (oddProd == evenProd)
        {
            Console.WriteLine("yes \nproduct = {0}", oddProd);
        }
        else
        {
            Console.WriteLine("no \nodd_product = {0} \neven_product = {1}", oddProd, evenProd);
        }
    }
}
