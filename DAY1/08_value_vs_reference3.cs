using static System.Console;

class CPoint
{
    public int x;
    public int y;
    public CPoint(int a, int b) { x = a; y = b; }
}
struct SPoint
{
    public int x;
    public int y;
    public SPoint(int a, int b) { x = a; y = b; }
}
class Program
{
    public static void Main()
    {
        // value_reference2.cs ������ ������
        // �Ʒ� �ڵ忡 ���� �׸��� "28page ������" �׸��Դϴ�.

        CPoint cp1;
        SPoint sp1;
        SPoint sp2 = new SPoint(1, 1);
    }
}

