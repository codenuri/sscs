using static System.Console;


class Program
{
    public static int M1() => 1;
    public static int M2() => 2;
    public static int M3() => 3;

    public static void Main()
    {
        Func<int> del = M1;
        del += M2;
        del += M3;

        // del 에는 3개의 메소드 등록
        // 그런데, 3개가 모두 반환값있음.
        int ret1 = del(); // 3개 메소드가 모두 호출되고
                          // 마지막 M3()결과가 ret1에 저장

        WriteLine($"{ret1}");

        // 3개의 모든 결과를 얻으려면 따로 호출합니다.
        foreach( Func<int> f in del.GetInvocationList())
        {
            int ret2 = f();

            WriteLine($"{ret2}");
        }
    }
}