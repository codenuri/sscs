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

        CPoint cp1; // 객체 생성 안됨. reference(포인터)만 만든것
        SPoint sp1; // 객체 생성 됨. 단, 생성자 호출안됨.
        SPoint sp2 = new SPoint(1, 1); // 객체 생성되고, 
                                       // 생성자 호출됨. 

        cp1.x = 1;      // error. 객체가 없음.

        int n1 = sp1.x; // error. 초기화되지 않은 변수를 읽는 코드
        sp1.x = 1;      // ok..초기화되지 않아도 쓰기는 가능.

        int n2 = sp2.x; // ok


        int a1;     // 초기화 안됨
        int a2 = 0; // int a2 = new int()의 의미 초기화됨.
    }
}

