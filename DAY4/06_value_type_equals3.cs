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


        // sp1, sp2 는 value_type 이므로 같은 객체 아닙니다.
        // => 서로 다른 객체인데, 상태는 동일
        // => 아래 코드는 신기하게도 모두 False 입니다.
        // => Boxing 현상 때문에
        WriteLine($"{object.ReferenceEquals(sp1, sp2)}"); // False
        WriteLine($"{object.ReferenceEquals(sp1, sp1)}"); // False

        // 결론 : value type 에는 아래 2개 사용시 에러는 아닙니다.
        //        그런데, 절대 사용하지 마세요
        //        Boxing 때문에 잘못된 결과
        WriteLine($"{object.Equals(sp1, sp1)}");
        WriteLine($"{object.ReferenceEquals(sp1, sp1)}");


        // 자세한 이야기는 "Boxing" 배울때.. 
    }

}



