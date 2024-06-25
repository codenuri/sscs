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
    // 규칙 4. reference 타입을 "out" 로 받으면
    // 1. 기존 객체의 속성 변경 ??
    // 2. 새로운 객체 담아오기 ??
    public static void OutModifier(out Point pt)
    {
        pt.x = 2;               // ?
      
        pt = new Point(3, 3);   //?
    }

    public static void Main()
    {
        Point p1 = new Point(1, 1);

        OutModifier(out p1);

        WriteLine($"{p1.x} {p1.y}");
    }
}