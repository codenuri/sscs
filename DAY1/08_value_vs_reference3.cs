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
        // value_reference2.cs 복사해 오세요
        // 아래 코드에 대한 그림이 "28page 오른쪽" 그림입니다.

        CPoint cp1;
        SPoint sp1;
        SPoint sp2 = new SPoint(1, 1);
    }
}

