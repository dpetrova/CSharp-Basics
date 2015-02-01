using System;

class NakovsMatching
{
    //We are given two words a and b. Each word can be split in several ways into left and right side:
    //•	a = (aLeft|aRight)
    //•	b = (bLeft|bRight)
    //The weight w(s) of given character sequence s is calculated as sum of the ASCII codes of its characters. The Nakov's 
    //distance between two split words (aLeft|aRight) and (bLeft|bRight) is defined as:
    //•	nakovs = w(aLeft) * w(bRight) - w(aRight) * w(bLeft), as absolute value
    //We assume that two word splits have good matching if their Nakov's difference is not greater than given limit number d.
    //Your task is to write a program that prints all good matchings between given two words a and b and given limit number d.
    //Example: a = "hello", b = "csharp", d = 20000. The word a can be split in 4 ways: "h|ello", "he|llo","hel|lo" and "hell|o".
    //The word b can be split in 5 ways: "c|sharp", "cs|harp", "csh|arp", "csha|rp" and "cshar|p". There are 20 possible 
    //matchings between the words a and b, but only 3 of them are good matchings (nakovs ≤ d):
    //(h|ello) matches (c|sharp) by 13996 nakovs	w(h) = 104, w(ello) = 428, w(c) = 99, w(sharp) = 542
    //                                              nakovs = abs(104 * 542 - 428 * 99) = 13996 ≤ 20000
    //(he|llo) matches (cs|harp) by 17557 nakovs	w(he) = 205, w(llo) = 327, w(cs) = 214, w(harp) = 427
    //                                              nakovs = abs(205 * 427 - 327 * 214) = 17557 ≤ 20000
    //(hell|o) matches (cshar|p) by 11567 nakovs	w(hell) = 421, w(o) = 111, w(cshar) = 529, w(p) = 112
    //                                              nakovs = abs(421 * 112 - 529 * 111) = 11567 ≤ 20000
    //Your task is to write a program that enters a, b and d and prints on the console all good matchings between a and b.
    //Input
    //The input data should be read from the console. It consists of 3 lines:
    //•	The first line hold the first string.
    //•	The second line holds the second string.
    //•	The third line holds the limit number d.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //Print on the console all good matchings between these two words in format "(aLeft|aRight) matches (bLeft|bRight)
    //by XXX nakovs", each at separate line. The order of the output lines is not important. Print "No" if no good matchings
    //are found.
    //Constraints
    //•	The input words a and b consist of small Latin letters only. The length of the words is in the range [2…20].
    //•	The number d is integer in the range [0…5 000 000].
    //•	Allowed working time: 0.25 seconds. Allowed memory: 16 MB.
    
    public static int nakovDistance = 0;
    public static bool foundGoodMatchings = false;

    static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        int d = int.Parse(Console.ReadLine());
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = 0; j < b.Length - 1; j++)
            {
                string aLeft = a.Substring(0, i + 1);
                string aRight = a.Substring(i + 1, a.Length - (i + 1));
                string bLeft = b.Substring(0, j + 1);
                string bRight = b.Substring(j + 1, b.Length - (j + 1));
                if (CalcNakovDistance(aLeft, aRight, bLeft, bRight) <= d)
                {
                    foundGoodMatchings = true;
                    Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs", aLeft, aRight, bLeft, bRight, nakovDistance);
                }
            }
        }
        if (!foundGoodMatchings)
        {
            Console.WriteLine("No");
        }
    }

    private static int CalcNakovDistance(string aLeft, string aRight, string bLeft, string bRight)
    {
        int weightALeft = 0;
        int weightARight = 0;
        int weightBLeft = 0;
        int weightBRight = 0;
        for (int i = 0; i < aLeft.Length; i++)
        {
            weightALeft += aLeft[i];
        }
        for (int j = 0; j < aRight.Length; j++)
        {
            weightARight += aRight[j];
        }
        for (int k = 0; k < bLeft.Length; k++)
        {
            weightBLeft += bLeft[k];
        }
        for (int m = 0; m < bRight.Length; m++)
        {
            weightBRight += bRight[m];
        }
        nakovDistance = Math.Abs((weightALeft * weightBRight) - (weightARight * weightBLeft));
        return nakovDistance;
    }
    
}
