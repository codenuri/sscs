using static System.Console;

class Program
{
    // 일반적인 함수(메소드)의 모양은 아래와 같습니다.
    public static int Square(int x)
    {
        return x * x;
    }

    // C# 에서는 구현부가 단순한 경우 아래 처럼 만드는 경우가 대부분입니다.
    // => 아래 코드는 위와 완전히 동일합니다.
    // => "expression bodied" 라는 문법 입니다.
    public static int Square1(int x) => x * x;



    public static void Main()
    {
        int ret = Square(3);

        WriteLine($"{ret}");
    }
}
