// 58page ±×¸² ~ 
using static System.Console;

class Point
{
    public int x = 0;
    public int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);
}

class Program
{
    public static void RefModifier(ref Point pt)
    {
        pt.x = 2;
        pt.y = 2;

//        pt = new Point(3, 3);
    }

    public static void Main()
    {
        Point p1 = new Point(1, 1);
        Point p2 = p1;

        RefModifier(ref p1);

        WriteLine($"{p1.x} {p1.y}");
        WriteLine($"{p2.x} {p2.y}");
    }
}