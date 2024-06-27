using static System.Console;

//class Point 
struct Point
{
	public int X{set; get;} = 0;
	public int Y{set; get;}	= 0;

	public Point(int a, int b) => (X, Y) = (a, b);
}

class Program
{
	public static bool MyReferenceEquals(object a, 
										 object b)
	{
		return a == b;
	}

	public static void Main()
	{
		// Point 는 Value Type
		Point p = new Point(1, 1);

		// #1. ValueType 은 == 연산 안됩니다.
        // p == p; // error

        WriteLine($"{MyReferenceEquals(p, p)}");
						// 같은 객체를 보내지만 결과는 False 입니다.
						// Boxing 때문에 받으면서 각각 복사본 생성
						// 2개의 복사본은 동일객체가 아니므로 False


//		WriteLine($"{object.ReferenceEquals(p, p)}");

    }
}