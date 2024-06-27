// 75 page ~ 
using static System.Console;

// interface : 클래스가 지켜야 하는 규칙(메소드이름)을 정의 하는 문법 

// 핵심 #1. C# 에서 인터페이스를 만드는 방법
interface FirstGroup
{
	// 이 안에 메소드 선언만 포함.
	// public, virtual 등을 표기하지 않고, 구현부도 없음
	void M1();
	int M2(int arg);
}

// #2. 인터페이스에서 만든 규칙을 따르려면 "상속" 표기법사용
// => Example 은 "FirstGroup" 규칙을 지키겠다는 의미
class Example : FirstGroup
{
	// #3. Example 클래스는 반드시 FirstGroup 인터페이스에서 약속한
	//     메소드를 구현해야 한다.
	public void M1() { }
	public int M2(int arg) { return 0; }
}

class Program 
{
	public static void Main()
	{
		// #4. interface 는 객체를 생성할수 없습니다.
		FirstGroup g = new FirstGroup();

		// #5. 하지만 interface 타입은 참조로서는 사용가능합니다.
		FirstGroup g2 = new Example(); // ok
		 
		// 즉, interface 는 객체는 만들수 없지만
		// 참조 변수로는 사용가능합니다.
		
	}
}
