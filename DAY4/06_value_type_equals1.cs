using static System.Console;

struct SPoint
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public SPoint(int a, int b) => (X, Y) = (a, b);
}

class Program
{
    public static void Main()
    {
        int n1 = 10;
        int n2 = 10;

        SPoint sp1 = new SPoint(1, 2);
        SPoint sp2 = new SPoint(1, 2);

        // value type 의 equality
        // #1. == 연산자


    }



}
