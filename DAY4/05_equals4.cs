// 107 page ~  
using System.Runtime.Remoting;

class Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public Point(int a, int b) => (X, Y) = (a, b);

    // == �� �⺻�����θ� "��ü�� ������(���ϰ�ü�ΰ�)" �Դϴ�
    // �׷���, ������ �����Ǹ� ���ؼ� "������ ������"���� �����Ҽ� �ֽ��ϴ�.
    public static bool operator==(Point a, Point b)
    {
        return a.X == b.X && a.Y == b.Y;
    }
    // == ������ != �� ���� �����ϴ� ���� ��Ģ �Դϴ�.
    public static bool operator !=(Point a, Point b)
    {
        return !(a == b);
    }
}

class Program
{
    public static void Main()
    {       
        Point p1 = new Point(1, 2);
        Point p2 = new Point(1, 2);

        Console.WriteLine($"{p1 == p2}");  // true

        // == �� operator overloading �Ǿ� �־
        // ��ü�� �������� �����ϰ� �ʹ�.
        Console.WriteLine($"{(object)p1 == (object)p2}");  







        string s1 = new string("ABC");
        string s2 = new string("ABC");

        // s1, s2 �� �ٸ� ��ü
        Console.WriteLine($"{s1 == s2}");  // True.
                    // ��, string �� "operator==" �޼ҵ� ������
    }
}



