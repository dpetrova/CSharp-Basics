using System;

class Illuminati
{
    //The illuminati are an ancient, very secret society that very secretly rules the world. They’ve managed to keep their existence
    //secret by using a very secretive way of communication. Their secret is that they incorporate their secret messages into
    //popular (non-secret) movies.
    //Your task is to extract the meaning of some movie lines. The messages are actually codes that can be extracted by summing
    //the secret values of every vowel in the message. The values of the vowels are as follows:
    //A = 65, E = 69, I = 73, O = 79, U = 85. The values apply for both upper and lowercase letters. 
    //For example, ‘I am Batman!’ has a total of 4 vowels: three times ‘A’ and one time ‘I’ and their sum is: 3 * 65 + 1 * 73 = 268.
    //Input
    //•	The input data should be read from the console.
    //•	The only input line holds the message that has to be deciphered.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //•	The output data should be printed on the console.
    //•	On the first output line you must print the number of vowels in the message.
    //•	On the second output line you must print the sum of all the vowels in the message.
    //Constraints
    //•	The length of the message will be between 1 and 800 000 characters.
    //•	Allowed working time for your program: 0.1 seconds.
    //•	Allowed memory: 16 MB.

    static void Main()
    {
        string str = Console.ReadLine();
        int numberOfVowels = 0;
        int sumOfVowels = 0;
        foreach (var letter in str)
        {
            switch (letter)
            {
                case 'A':
                case 'a':
                    numberOfVowels++;
                    sumOfVowels += 65;
                    break;
                case 'E':
                case 'e':
                    numberOfVowels++;
                    sumOfVowels += 69;
                    break;
                case 'I':
                case 'i':
                    numberOfVowels++;
                    sumOfVowels += 73;
                    break;
                case 'O':
                case 'o':
                    numberOfVowels++;
                    sumOfVowels += 79;
                    break;
                case 'U':
                case 'u':
                    numberOfVowels++;
                    sumOfVowels += 85;
                    break;
            }
        }
        Console.WriteLine(numberOfVowels);
        Console.WriteLine(sumOfVowels);
    }
}
