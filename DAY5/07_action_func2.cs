
// Action : 반환타입이 void 인경우의 delegate
// Func   : 반환 타입이 void가 아닌 경우
/*
delegate R Func<R>();
delegate R Func<T, R>(T arg);
delegate R Func<T1, T2, R>(T1 arg1, T2 arg2);
*/
class Program 
{
	public static int    M1() => 0;
	public static double M2(int arg) => 0;
	public static string M3(double arg) => "";
	public static object M4(int arg1, double arg2) => 0;

	public static void Main()
	{
		Func<int> f1 = M1;
		Func<int, double> f2 = M2;
		? f3 = M3;
		? f4 = M4;
    }
}
