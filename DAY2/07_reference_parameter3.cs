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
    public static void NoModifier(Point pt)
    {
        pt.x = 2;
        pt.y = 2;

        // 이예제의 핵심은 아래 한줄!
        pt = new Point(3, 3);
    }

    public static void Main()
    {
        Point p1 = new Point(1, 1);
        Point p2 = p1;

        NoModifier(p1);

        WriteLine($"{p1.x} {p1.y}");
        WriteLine($"{p2.x} {p2.y}");
    }
}