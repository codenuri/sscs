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

        // #2. Equals() 가상 메소드
        // => Object 의 기본 구현은 " == " 사용. 
        // => ValueType 클래스에서 "Equals" 를 override 해서
        //    2개 객체의 메모리를 통째로 비교(C언어의 memcmp 같이)
        //    상태 동질성 비교

        // => 일부 멤버만 비교하도록 하려면 override 하면 됩니다.
        WriteLine($"{sp1.Equals(sp2)}");

    }

}
