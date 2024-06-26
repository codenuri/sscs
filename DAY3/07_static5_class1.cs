using static System.Console;

// 수학관련 함수를 라이브러리로 제공하고 싶다.
// => C언어는 "멤버가 아닌 일반 함수" 라는 것을 만들수 있지만
// => C#은 모든 것을 클래스로만 만들수 있다.
// => "top level programming" 도 결국 Main 함수안으로 이동하는 것

// #1. 아래 처럼 일반(멤버가 아닌) 함수로 만들수 없습니다.
/*
int Max(int a, int b)
{
	return a < b ? b : a;
}

int Square(int x)
{
	return x * x;
}
*/

// #2. 클래스로 만들어야 합니다.
// Date, Person, Point, Rect : 상태(필드)가 있으므로 객체를 생성해서 보관해야합니다.
// Math : 단지, 수학관련 메소드를 제공할뿐, 저장될 데이타는 없습니다.
//        모든 메소드를 static 으로 하는 것이 편리합니다.

// static class : 모든 멤버가 static 인 클래스
//                객체를 생성할수 없게 하기 위해 사용.
//                Math 를 static 으로 안해도 되지만, 안전하게 하기 위해서는
//                static class 로 설계 하는 것이 좋다.
static class Math
{
    public static int Max(int a, int b)
    {
        return a < b ? b : a;
    }

    public static int Square(int x)
    {
        return x * x;
    }
}

class Program 
{
	public static void Main()
	{
        int n = Math.Square(2);

//        Math m = new Math();
	}
}