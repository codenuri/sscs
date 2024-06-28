using static System.Console;

class Program
{
    static bool IsEven(int n) { return n % 2 == 0; }

	public static void Main()
    {
        int[] array = { 1, 3, 6, 4, 5 };

		int idx1 = Array.FindIndex(array, IsEven);

        // lambda expression : 익명의 메소드를 만드는 문법
        
        // #1. 정확한 표기법
        int idx2 = Array.FindIndex(array, bool (int n) => { return n % 2 == 0; } );

        // #2. C# 의 특징은 "다양한 편의 표기법이 있다는 점."
        // 람다 표현식도 역시 편의 표기법 제공

        Array.FindIndex(array, (int n) => { return n % 2 == 0; }); // return type 추론가능

        Array.FindIndex(array, (int n) => n % 2 == 0 ); // expression bodied 가능.

        Array.FindIndex(array, (n) => n % 2 == 0); // 인자의 타입도 생략 가능.
                                                   // array 가 int 라는 것을 알기 때문에

        Array.FindIndex(array, n => n % 2 == 0); // 인자가 한개이면 () 없어도 됨

 //       Array.FindIndex(array, $1 % 2 == 0); // swift 는 이렇게도 됩니다

    }
}
