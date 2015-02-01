using System;

class InsideTheBuilding
{
    //In Absurdistan the buildings look like the figure on the right. They consist of 6 blocks of size h * h. 
    //Their bottom-left corner is located at the coordinates (0, 0). See the figure (for h = 2) to get a better idea.
    //Write a program that enters a size h and 5 points {x1, y1}, {x2, y2}, {x3, y3}, {x4, y4}, and {x5, y5} and prints for each
    //of the points whether it is inside or outside of the building. Points at the building's border, like {0, 0}, 
    //are considered inside.
    //Input
    //The input data should be read from the console.
    //•	At the first line an integer number h specifying the size of the building will be given.
    //•	At the next 10 lines the numbers x1, y1, x2, y2, x3, y3, x4, y4, x5, y5 are given.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console. It should consist of exactly 5 lines. At each line print either "inside" or "outside" depending of where each of the 5 input points are located.
    //Constraints
    //•	All numbers in the input will be integers in the range [-1000 … 1000].
    //•	Allowed working time for your program: 0.1 seconds.
    //•	Allowed memory: 16 MB.


    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 5; i++)
        {
            int xi = int.Parse(Console.ReadLine());
            int yi = int.Parse(Console.ReadLine());
            string result;
            if (xi < 0 || xi > 3 * h || yi < 0 || yi > 4 * h || (xi < h && yi > h) || (xi > 2 * h && yi > h))
            {
                result = "outside";
            }
            else
            {
                result = "inside";
            }
            Console.WriteLine(result);
        }
    }
}
