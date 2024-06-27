// 107 page ~  
using System.Runtime.Remoting;

class Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public Point(int a, int b) => (X, Y) = (a, b);
}

class Program
{
    public static void Main()
    {       
        Point p1 = new Point(1, 2);
        Point p2 = p1;

        Console.WriteLine($"{p1 == p2}");

    }
}



