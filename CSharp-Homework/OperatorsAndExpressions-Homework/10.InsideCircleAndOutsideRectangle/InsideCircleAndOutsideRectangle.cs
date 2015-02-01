using System;

class InsideCircleAndOutsideRectangle
{
    static void Main()
    {
        Console.Write("enter x coordinate of a point:");
        double x = double.Parse(Console.ReadLine());
        Console.Write("enter y coordinate of a point:");
        double y = double.Parse(Console.ReadLine());
        double circleX0 = 1;
        double circleY0 = 1;
        double radius = 1.5;
        bool insideCircle = (((x - circleX0) * (x - circleX0) + (y - circleY0) * (y - circleY0)) <= radius * radius);
        bool outsideRectangle = x < -1 || x > 5 || y > 1 || y < -1;
        if (insideCircle && outsideRectangle)
        {
            Console.WriteLine("inside circle & outside of rectangle");
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("inside circle & outside of rectangle");
            Console.WriteLine("No");
        }
    }
}
