using static System.Console;

class Program
{
    // a    : required parameter. 반드시 전달해야 합니다.
    // b, c : optional parameter. 선택입니다.
    //        C++ : default parameter 라고 합니다.
    //        python 도 됩니다.
    //        java 안됩니다.
    public static void M1(int a, int b = 0, int c = 0)
	{
	 	WriteLine($"{a}, {b}, {c}");
	} 
    
    public static void Main()
    {
        M1(10, 20, 30); // 10, 20, 30
        M1(10, 20);
        M1(10);
    }
    // 주의 사항
    // => optional 인자 다음에 required가 나올수 없습니다.
    // => 마지막 인자부터 차례대로 표기해야 합니다.
    public static void M2(int a, int b = 0, int c = 0) { }  // ok
    public static void M3(int a = 0, int b, int c = 0) { }  // error
    public static void M4(int a, int b = 0, int c) { }      // error
}



