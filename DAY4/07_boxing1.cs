// 116p ~ 
using static System.Console;

class CPoint 
{
	public int X{set; get;} = 0;
	public int Y{set; get;}	= 0;
	public CPoint(int a, int b) => (X, Y) = (a, b);
}

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
		// object : class 입니다.(struct 아님)

		// 116 그림 참고 - 오른쪽 그림
		CPoint cp1 = new CPoint(1, 1);
		object o = cp1;		
		CPoint cp2 = (CPoint)o;

		cp1.X = 2; 
		cp1.Y = 2;

		Console.WriteLine($"{cp2.X}, {cp2.Y}"); // 2, 2

        //-----------------------------------
		// 117p 왼쪽
        SPoint sp1 = new SPoint(1, 1);


        object o = sp1;
       
		
		
		SPoint sp2 = (SPoint)o;



        sp1.X = 2;
        sp1.Y = 2;

        Console.WriteLine($"{sp2.X}, {sp2.Y}"); // 1, 1

    }
}