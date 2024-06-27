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

        // Reference Type �� ���. 
        // ��� #1. == ������ ���
        // => ��ü�� ���ϼ� ���� ( ���� ��ü�ΰ�)
        Console.WriteLine($"{p1 == p2}, {p3 == p4}"); // True, False


        // ��� #2. object �� ���� ��� �޴� Equals()�����Լ� ���
        Console.WriteLine($"{p1.Equals(p2)}, {p3.Equals(p4)}");
    }
}
