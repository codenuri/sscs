using static System.Console;

// static constructor
// => 다른 객체지향언어에는 없는 C# 만의 특징.
// => 초급 시절에는 많이 사용하지 않지만 고급 기술로 활용됨. 
class Train
{
	private int speed = 0;

	// 생성자 : 객체당 한번씩 호출
	public Train() { WriteLine("Train()"); speed = 50; }

	// static 생성자 : 최초 1회만 호출.
	//				   객체를 10개 만들어도 처음에 한번만 호출
	//			      접근지정자(public)을 표기하지 않습니다.
    static Train() { WriteLine("static Train()");  }
}

class Program 
{
	public static void Main()
	{
		Train t1 = new Train();
		Train t2 = new Train();
		Train t3 = new Train();
	}
}