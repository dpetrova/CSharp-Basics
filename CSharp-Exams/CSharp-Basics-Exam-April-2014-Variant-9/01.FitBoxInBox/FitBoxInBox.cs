using System;

class FitBoxInBox
{
    //Nakov likes boxes. Ha has many boxes at home. To save space he often puts his boxes one inside another. A box can fit
    //inside another box if the size of the smaller box is smaller than the size of the bigger box in erall dimensions at the 
    //same time. Of course, boxes can be rotated to fit one inside another. Here are few examples:
    //•	(5, 1, 6) fits naturally in (6, 2, 9), because 5 < 6 and 1 < 2 and 6 < 9
    //•	(5, 1, 6) fits in (2, 7, 6) after rotating the second box to (6, 2, 7)
    //•	(7, 8, 1) cannot fit in (12, 7, 3) even after rotating
    //•	(6, 2, 9) cannot fit in (5, 1, 6) even after rotating
    //You are given the sizes of two boxes (width, height and depth). Write a program to check whether the boxes can fit one
    //inside another and how exactly. Print the smaller box first, exactly as it is given in the input (without rotating),
    //followed by "<" and the larger box (eventually rotated) to fit each of the dimensions. Print all possible ways to put 
    //the smaller box into the larger box. In case there is no smaller box, print nothing. See the examples below to catch
    //the idea.
    //Input
    //The input data comes from the console. It holds exactly 6 different numbers, each at a separate line:
    //•	The first 3 lines hold the dimensions of the first box (width, height and depth).
    //•	The second 3 lines hold the dimensions of the second box (width, height and depth).
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. It should consist of zero or more lines:
    //•	If a smaller box exists, print all possible ways to fit the smaller box (without rotation) in the larger box (eventually rotated) in format: (w1, h1, d1) < (w2, h2, d2). Note that the first box is smaller if w1 < w2 and h2 < h2 and d1 < d2. Beware of whitespaces in the output format!
    //•	Print each possible fit into a separate line. The lines order is not important.
    //•	In case of no smaller box exists, print nothing.
    //Constraints
    //•	All input numbers are unique integers in [1 … 1000].
    //•	Time limit: 0.1 seconds.
    //•	Memory limit: 16 MB.

    static void Main()
    {
        int w1 = int.Parse(Console.ReadLine());
        int h1 = int.Parse(Console.ReadLine());
        int d1 = int.Parse(Console.ReadLine());
        int w2 = int.Parse(Console.ReadLine());
        int h2 = int.Parse(Console.ReadLine());
        int d2 = int.Parse(Console.ReadLine());

        // Try to fit the first box inside the second box (6 possibilities)
        CheckBoxes(w1, h1, d1, w2, h2, d2);
        CheckBoxes(w1, h1, d1, w2, d2, h2);
        CheckBoxes(w1, h1, d1, h2, w2, d2);
        CheckBoxes(w1, h1, d1, h2, d2, w2);
        CheckBoxes(w1, h1, d1, d2, w2, h2);
        CheckBoxes(w1, h1, d1, d2, h2, w2);

        // Try to fit the second box inside the first box (6 possibilities)
        CheckBoxes(w2, h2, d2, w1, h1, d1);
        CheckBoxes(w2, h2, d2, w1, d1, h1);
        CheckBoxes(w2, h2, d2, h1, w1, d1);
        CheckBoxes(w2, h2, d2, h1, d1, w1);
        CheckBoxes(w2, h2, d2, d1, w1, h1);
        CheckBoxes(w2, h2, d2, d1, h1, w1);
    }

    private static void CheckBoxes(int firstWidth, int firstHeight, int firstDepth,
                                                int secondWidth, int secondHeight, int secondDepth)
    {
        if (firstWidth < secondWidth && firstHeight < secondHeight && firstDepth < secondDepth)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                firstWidth, firstHeight, firstDepth, secondWidth, secondHeight, secondDepth);
        }
    }
}
