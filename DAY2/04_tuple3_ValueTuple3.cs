using static System.Console;

class Point
{
	public int x = 0;
	public int y = 0;

	public Point(int a, int b)
	{
		// 아래 처럼 작성하면 2줄이 필요 합니다.
		//x = a;
		//y = b;

		// 아래 처럼할수도 있습니다.
		// => tuple deconstruction 기법
		(x, y) = (a, b);

		// 아래 코드와 잘 구별하세요.
		// => tuple 의 생성은 변수가 있습니다
		//(int x, int y) t1 = (a, b);
	}

    // 일반적으로 메소드의 반환값은 한개 입니다.
    // => 하지만 tuple 로 반환하면 2개 이상 반환 가능합니다.
    // public var Get()	// error. var 를 리턴 자리에 사용할수 없습니다
    // public ValueTuple<int, int> Get() // ok

    // public (int, int) Get() // ok
    public (int x, int y) Get() // ok
    {
		return (x, y);
	}
}
class Program 
{
	public static void Main()
	{
		Point p = new Point(1,2);

		var ret = p.Get(); // ret 는 (int, int) 타입입니다.
		WriteLine($"{ret.Item1}, {ret.Item2}");
        WriteLine($"{ret.x}, {ret.y}");


        var ret1       = p.Get(); // 반환결과를 tuple 에 담은 것
		(int x, int y) = p.Get(); // 반환 결과를 deconstruction 해서
                                  // int 2개 변수에 담은것

        WriteLine($"{x}, {y}");
    }
}
