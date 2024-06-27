// 107 page ~  
class Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public Point(int a, int b) => (X, Y) = (a, b);
}

class Program
{
	public static void Main() 
	{		
		// 핵심 : 같은 객체 와 같은 상태(속성) 을 구별해 보세요

		// p1, p2 는 "같은 객체"
		Point p1 = new Point(1,2);
		Point p2 = p1;


		// p3, p4 는 "다른 객체지만 같은 상태"
		Point p3 = new Point(1,2);
		Point p4 = new Point(1,2);

		// 항상 동일성을 조사할때는 
		// "객체의 동일성" 인지 "상태의 동일성" 인지를 구별하세요
	}
}
