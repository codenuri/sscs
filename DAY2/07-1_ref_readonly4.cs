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
    // reference type 을 in 으로 전달할때
    // in 으로 전달하면
    // 1. 복사본이 아닌 주소 전달(reference 전달)
    // 2. 가리키는 곳을 변경할수 없음.

    // 따라서, 객체는 수정할수 있지만
    // 새로운 객체를 만들어서 담아올수는 없다!!
    // => 메모리를 잘생각해 보세요.
    public static void InParameter(in Point pt)
    {
        pt.x = 2; // ok
        pt.y = 2; // ok

        pt = new Point(3, 3); // error
    }
    public static void Main()
    {
        Point p1 = new Point(1, 1);
        InParameter(p1);

    }
}