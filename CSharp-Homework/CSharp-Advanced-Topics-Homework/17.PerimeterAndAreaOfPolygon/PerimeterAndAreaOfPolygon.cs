using System;
using System.Collections.Generic;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

class Polygon
{
    public List<Point> vertices { get; set; }
}

class PerimeterAndAreaOfPolygon
{
    static void Main()
    {
        Console.Write("enter number of edges of the polygon:");
        int n = int.Parse(Console.ReadLine());
        Polygon userPolygon = new Polygon();
        string[] coordinates = new string[2];
        userPolygon.vertices = new List<Point>();
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("enter x and y coordinates of the vertex, separated by a space:");
                coordinates = Console.ReadLine().Split();
                userPolygon.vertices.Add(new Point() { X = int.Parse(coordinates[0]), Y = int.Parse(coordinates[1]) });
            }
        };

        CalcPerimeter(userPolygon);

        CalcArea(userPolygon);
    }

    static void CalcPerimeter(Polygon userPolygon)
    {
        double dx = 0;
        double dy = 0;
        double distance = 0;
        double perimeter = 0;
        int j = userPolygon.vertices.Count - 1; // The last vertex is the 'previous' one to the first
        for (int i = 0; i < userPolygon.vertices.Count; i++)
        {
            dx = userPolygon.vertices[j].X - userPolygon.vertices[i].X;
            dy = userPolygon.vertices[j].Y - userPolygon.vertices[i].Y;
            j = i; //j is previous vertex to i
            distance = Math.Sqrt(dx * dx + dy * dy);
            perimeter += distance;
        }
        Console.WriteLine("perimeter = {0:f2}", perimeter);
    }

    static void CalcArea(Polygon userPolygon)
    {
        //double customArea = 0;         // Accumulates area in the loop
        //int j = userPolygon.vertices.Count - 1;  // The last vertex is the 'previous' one to the first

        //for (int i = 0; i < userPolygon.vertices.Count; i++)
        //{
        //    customArea = customArea + (userPolygon.vertices[j].X + userPolygon.vertices[i].X) * (userPolygon.vertices[j].Y - userPolygon.vertices[i].Y);
        //    j = i;  //j is previous vertex to i
        //}
        //double area = Math.Abs(customArea / 2);
        //Console.WriteLine(area);

        double customArea = 0; // Accumulates area in the loop
        int j = userPolygon.vertices.Count - 1; // The last vertex is the 'previous' one to the first
        for (int i = 0; i < userPolygon.vertices.Count; i++)
        {
            customArea += (userPolygon.vertices[j].X * userPolygon.vertices[i].Y) - (userPolygon.vertices[j].Y * userPolygon.vertices[i].X);
            j = i; //j is previous vertex to i
        }
        double area = Math.Abs(customArea / 2);
        Console.WriteLine("area = {0:f2}", area);
    }


}

