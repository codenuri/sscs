// 27page ~ 
using static System.Console;

// #1. CPoint 와 SPoint 는 이름을 제외하면 완전히 동일합니다.
// #2. 단, CPoint 는 class, SPoint 는 struct 입니다

class CPoint
{
	private int x;
	private int y;
	public CPoint(int a, int b) { x = a; y = b;}
}
struct SPoint
{
	private int x;
	private int y;
	public SPoint(int a, int b) { x = a; y = b;}	
}
class Program 
{
	public static void Main()
	{
		// 아래 코드는 객체를 생성하는 방법은 완전히 동일합니다.
		// => 그런데 메모리 구조는 완전히 다릅니다.
		// => 교재 27 page 왼쪽 그림
		CPoint cp = new CPoint(0, 0);
        SPoint sp = new SPoint(0, 0);




		int n1 = 0;         // new int() 인데 struct 입니다.
		string s1 = "ABCD"; // new string("ABCD") 인데 class입니다


		// 배열은 "값 타입" 일까요? "참조 타입" 일까요 ?
		// C# : reference type.  배열 자체는 "힙" 있고,
		//	    arr는 힙에 있는 데이타를 가리키는 레퍼런스(주소)

		// swift : value type 으로 설계됨. 배열 자체가 "stack" 에 있음
		//         배열의 할당/해지가 C# 보다 빠름. 

		int[] arr = { 1, 2, 3, 4, 5 };


		// 날짜와 시간은 다루는 타입입니다.
		// => value type 일까요 ? reference type 일까요 ?
		DateTime tm = new DateTime(2024, 1, 1);
	}
}
