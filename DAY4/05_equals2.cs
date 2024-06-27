// 107 page ~  
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
        Point p3 = new Point(1, 2);
        Point p4 = new Point(1, 2);

        // Reference Type 인 경우. 
        // 방법 #1. == 연산자 사용
        // => 객체의 동일성 조사 ( 동일 객체인가)
        Console.WriteLine($"{p1 == p2}, {p3 == p4}"); // True, False


        // 방법 #2. object 로 부터 상속 받는 Equals()가상함수 사용
        Console.WriteLine($"{p1.Equals(p2)}, {p3.Equals(p4)}");
    }
}
