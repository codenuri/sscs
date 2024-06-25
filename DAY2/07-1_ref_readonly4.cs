// 58page 그림 ~ 
using static System.Console;

class Point
{
    public int x = 0;
    public int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);
}

class Program
{
    public static void InParameter(in Point pt)
    {
        pt.x = 2;
        pt.y = 2;
    }
    public static void Main()
    {
        Point p1 = new Point(1, 1);
        InParameter(p1);

    }
}