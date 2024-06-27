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

}

class Program 
{
	public static void Main()
	{
				
	}
}
