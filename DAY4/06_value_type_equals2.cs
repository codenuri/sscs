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
        SPoint sp2 = new SPoint(1, 2);

        // #2. Equals() ���� �޼ҵ�
        // => Object �� �⺻ ������ " == " ���. 
        // => ValueType Ŭ�������� "Equals" �� override �ؼ�
        //    2�� ��ü�� �޸𸮸� ��°�� ��(C����� memcmp ����)
        //    ���� ������ ��

        // => �Ϻ� ����� ���ϵ��� �Ϸ��� override �ϸ� �˴ϴ�.
        WriteLine($"{sp1.Equals(sp2)}");

    }

}
