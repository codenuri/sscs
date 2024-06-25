using static System.Console;

class Program
{
	// 덧셈과 뺄셈의 결과를 반환하는 메소드
	public static int AddSub1(int a, int b, ref int n)
	{
		n = a - b;
		return a + b;
	}

    public static int AddSub2(int a, int b, out int n)
    {
        n = a - b;
        return a + b;
    }

    public static void Main()
	{
//		int ret1 = 0;
        int ret1;       // 초기화 안됨.

//      int ret2 = AddSub1(5, 3, ref ret1); // error. ref 전달은
                                            // 초기화된 변수만 가능
                                            // 즉, 함수 안에서 R/W하겠다는 의도


        int ret2 = AddSub2(5, 3, out ret1); // ok. 초기화 되지 않은 인자도 가능

        // C#7.0 부터 out 파라미터는 인자 전달 시점에 변수 선언도 가능해졌습니다.

        int ret3 = AddSub2(5, 3, out int x); // ok. x 의 선언 자체를 인자 안에표기

        WriteLine($"{ret1} {ret2}");
	}
}