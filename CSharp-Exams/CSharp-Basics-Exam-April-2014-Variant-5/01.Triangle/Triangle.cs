using System;

class Triangle
{
    //You are given a two-dimensional Cartesian coordinate system and three points A, B, C with coordinates: A(Ax, Ay), B(Bx,  By),
    //C(Cx, Cy). Write a program to check if these three points can form a triangle. Then calculate the area of this triangle. 
    //To find the distance between two points with the coordinates (x1, y1) and (x2, y2) use the formula:
    //                 D= √((x2-x1)^2 + (y2-y1)^2)  
    //You can use the inequalities of a triangle to check whether three segments a, b and c can form a triangle:
    //                  a+b>c;  b+c>a; a+c>b
    //To calculate the area you can use Heron`s formula (a method for calculating the area of a triangle when you know the lengths
    //of all three sides). Let a, b, c be the lengths of the sides of a triangle. Thus:
    //                Area=√(p(p-a)(p-b)(p-c) ), where p is half the perimeter: (a+b+c)/2.
    //Input
    //The input data comes from the console. It consists of exactly 6 lines holding the coordinates of the three points: 
    //Ax-coordinate, Ay-coordinate, Bx-coordinate, By-coordinate, Cx-coordinate and Cy-coordinate. 
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output data should be printed on the console and must contain two lines. 
	//First line: If the given points can form a triangle you must print the message “Yes”, otherwise “No”.
	//Second line: If the given points can form a triangle you must print the area of the triangle rounded to two decimal places 
    //(see the examples), otherwise you must print the distance between point A and point B. Use "." as decimal separator.
    //Constraints
	//The coordinate X is integer in the range [-10000… 10000] inclusive.
	//The coordinate Y is integer in the range [-10000… 10000] inclusive.
	//Allowed work time for your program: 0.1 seconds.
	//Allowed memory: 16 MB.

    static void Main()
    {
        int ax = int.Parse(Console.ReadLine());
        int ay = int.Parse(Console.ReadLine());
        int bx = int.Parse(Console.ReadLine());
        int by = int.Parse(Console.ReadLine());
        int cx = int.Parse(Console.ReadLine());
        int cy = int.Parse(Console.ReadLine());
        double sideA = Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by));
        double sideB = Math.Sqrt((bx - cx) * (bx - cx) + (by - cy) * (by - cy));
        double sideC = Math.Sqrt((cx - ax) * (cx - ax) + (cy - ay) * (cy - ay));
        if (sideA + sideB > sideC && sideB + sideC > sideA && sideA + sideC > sideB)
        {
            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
            Console.WriteLine("Yes \n{0:0.00}", area);
        }
        else
        {
            Console.WriteLine("No \n{0:0.00}", sideA);
        }
    }
}
