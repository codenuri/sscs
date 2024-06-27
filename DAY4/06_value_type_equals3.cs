using System.Drawing;
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
        SPoint sp1 = new SPoint(1, 2);
        SPoint sp2 = sp1;


        WriteLine($"{object.ReferenceEquals(sp1, sp2)}");

    }

}
