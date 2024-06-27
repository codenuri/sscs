// 107 page ~  
using System.Runtime.Remoting;

class Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public Point(int a, int b) => (X, Y) = (a, b);

    // == 는 기본적으로를 "객체의 동질성(동일객체인가)" 입니다
    // 그런데, 연산자 재정의를 통해서 "상태의 동질성"으로 변경할수 있습니다.

    static bool operator==(Point a, Point b)
    {
        return a.X == b.X && a.Y == b.Y;
    }
    // == 제공시 != 도 같이 제공하는 것이 원칙 입니다.
    static bool operator !=(Point a, Point b)
    {
        return !(a== b);
    }
}

class Program
{
    public static void Main()
    {       
        Point p1 = new Point(1, 2);
        Point p2 = new Point(1, 2);

        Console.WriteLine($"{p1 == p2}");

    }
}



