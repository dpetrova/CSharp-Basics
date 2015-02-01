using System;
using System.Collections.Generic;

class WeirdCombinations
{
    //You are given a sequence of 5 distinct numbers and/or letters. Find all possible combinations of 5 symbols 
    //containing the given numbers/letters. Then you will be given a number n. You have to find the n-th number in the
    //natural order of all combinations. Example: sequence = "a1bc2", n = 5, combinations: "aaaaa", "aaaa1", "aaaab", 
    //"aaaac", "aaaa2", "aaa1a", "aaa1b"…  "2222b", "2222c", "22222".  5th element = aaa1a (take notice that the first 
    //element in the order is counted as 0). If the n-th number doesn't exist in print "No".
    //Input
    //Input data is read from the console.
    //•	The sequence of letters/numbers stays at the first line.
    //•	The number n of stays at the second line.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output data must be printed on the console.
    //•	Print the n-th number in the natural order of all combinations.
    //Constraints
    //•	N will be an integer number between 0 and 5000 and 
    //•	Time limit: 0.25 seconds. Allowed memory: 16 MB.

    static void Main()
    {
        string str = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        char[] strAsCharArray = str.ToCharArray();
        List<string> combinations = new List<string>();
        for (int s1 = 0; s1 < strAsCharArray.Length; s1++)
        {
            for (int s2 = 0; s2 < strAsCharArray.Length; s2++)
            {
                for (int s3 = 0; s3 < strAsCharArray.Length; s3++)
                {
                    for (int s4 = 0; s4 < strAsCharArray.Length; s4++)
                    {
                        for (int s5 = 0; s5 < strAsCharArray.Length; s5++)
                        {
                            //if (s1 != s2 && s1 != s3 && s1 != s4 && s1 != s5 && s2 != s3 && s2 != s4 && s2 != s5 &&
                            //                                                            s3 != s4 && s3 != s5 && s4 != s5)
                            //{
                                combinations.Add("" + strAsCharArray[s1] + strAsCharArray[s2] + strAsCharArray[s3] +
                                                                                strAsCharArray[s4] + strAsCharArray[s5]);
                            //}
                        }
                    }
                }
            }
        }
        if (n < combinations.Count)
        {
            Console.WriteLine(combinations[n]);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
