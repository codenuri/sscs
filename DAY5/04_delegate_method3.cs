using static System.Console;

delegate void MyFunc(int arg);

class Program
{
	public static void M1(int arg)    {}
	public static void M2(double arg) {}
	public static int  M3(int arg) => 0;
	public static void M4(int other)  {}

	public static void Main()
	{
		MyFunc m1 = M1; // ok
		MyFunc m2 = M2; // error. 인자 타입이 다름.
		MyFunc m3 = M3; // error. 리턴 타입이 다름
		MyFunc m4 = M4; // ok     인자의 변수명이 다름
	}
}
