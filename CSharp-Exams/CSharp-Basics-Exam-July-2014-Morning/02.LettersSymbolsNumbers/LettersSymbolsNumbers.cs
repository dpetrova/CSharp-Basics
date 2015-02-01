using System;
using System.Text.RegularExpressions;

class LettersSymbolsNumbers
{
    //You are given N strings. Every string consists of letters, symbols, numbers and whitespace. All letters (a-z) and (A-Z)
    //have values corresponding to their position in the English alphabet * 10 (a = 10, A = 10, b = 20, B = 20, …, 
    //z = 260, Z = 260). All symbols (like `~!@#$%^&*()_+{}:"|<>?-=[];'\,./) have a fixed value of 200 and all numbers have
    //the value of their digit * 20 (0 = 0, 1 = 20, 2 = 40, 3 = 60, …, 9 = 180). The whitespace is ignored. Your task is to
    //calculate the sum of all letters, all symbols and all numbers from the input and print them, each at a separate line.
    //Input
    //The input data should be read from the console.
    //•	At the first line an integer number N is given, specifying the count of the input strings.
    //•	Each of the next N lines holds an input string.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. It should consist of exactly 3 lines:
    //•	On the first line print the sum of all letters.
    //•	On the second line print the sum of all numbers.
    //•	On the third line print the sum of all symbols.
    //Constraints
    //•	N is an integer between in range [0… 1000].
    //•	All of the strings combined have a maximal length of 255 000 characters.
    //•	All characters, which are not Latin letters or whitespace, are considered symbols.
    //•	The whitespace are the symbols ' ', '\t', '\r' and '\n'.
    //•	Allowed working time for your program: 0.2 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int sumOfLetters = 0;
        int sumOfDigits = 0;
        int sumOfSymbols = 0;
        for (int i = 0; i < N; i++)
        {
            string input = Console.ReadLine();
            input = input.ToUpper(); // Convert the input to upper-case
            input = input.Trim(); //Remove leading and trailing white-spaces
            input = Regex.Replace(input, "\\s+", "");  // Remove the whitespace from the input

            // sums depending of Unicode characters numbers
            foreach (var item in input)
            {
                if (Char.IsLetter(item))
                {
                    sumOfLetters += (item % 64) * 10; //Capital letter A is 65
                }
                else if (Char.IsDigit(item))
                {
                    sumOfDigits += (item % 48) * 20; //Digit zero is 48
                }
                else
                {
                    sumOfSymbols += 200;
                }
            }
        }
        Console.WriteLine(sumOfLetters);
        Console.WriteLine(sumOfDigits);
        Console.WriteLine(sumOfSymbols);
    }
}
