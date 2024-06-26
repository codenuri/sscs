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
class Math
{
    int Max(int a, int b)
    {
        return a < b ? b : a;
    }

    int Square(int x)
    {
        return x * x;
    }
}

class Program 
{
	public static void Main()
	{

	}
}