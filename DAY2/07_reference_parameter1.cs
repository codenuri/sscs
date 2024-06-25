// 58page 그림 ~ 
using static System.Console;

class Point 
{
	public int x = 0;
	public int y = 0;
	public Point(int a, int b) => (x, y) = (a, b);
}

class Program 
{
	
	// 규칙 1. reference 타입은
	//		   ref, out  없이 전달해도
	//         객체의 상태를 변경할수 있다.

	public static void NoModifier(Point pt)
	{
		pt.x = 2;
		pt.y = 2;
	}	
	public static void Main()
	{
		Point p1 = new Point(1, 1);
		Point p2 = p1;

        // 아래 코드의 결과를 예측해 봅시다.
        NoModifier(p1); // Point pt = p1

		WriteLine($"{p1.x} {p1.y}"); 
		WriteLine($"{p2.x} {p2.y}"); 
	}
}