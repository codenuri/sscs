using static System.Console;

class Point
{
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;

    public Point(int a, int b) => (X, Y) = (a, b);

    public static Point operator+( Point p1, Point p2 )
    {
        Point p3 = new Point(p1.X + p2.X, p1.Y + p2.Y);

        return p3;
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);

        Point p3 = p1 + p2;  // Point.operator+(p1, p2)
   

        WriteLine($"{p3.X} {p3.Y}");
    }
}



