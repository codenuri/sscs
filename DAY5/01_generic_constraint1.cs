#nullable disable
using System;
using static System.Console;


class Point
{
	public int X{set;get;} = 0;
	public int Y{set;get;} = 0;
	public Point(int x, int y) => (X, Y) = (x, y);
}


class Program
{
    // Max(int, int) : int 만 인자로 사용가능
    // Max(T, T)     : 모든 타입 사용가능.

   
    public static T Max<T>(T a, T b) 
    {	
        // 이 안에서는 T 타입이 CompareTo 가 있다고 보장할수없습니다.
        // 따라서 아래 코드는 에러 입니다.
        // 이 안에서는 Object 로 할수 있는 일만 가능합니다.
        return a.CompareTo(b) < 0 ? b : a;
    }
   



    public static void Main()
    {
        var ret1 = Max(3, 4);
        var ret2 = Max(3.4, 4.2);
        var ret3 = Max("A", "B");



        Point p1 = new Point(1,1);
		Point p2 = new Point(2,2);
			
    }
}
