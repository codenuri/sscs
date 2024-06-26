using System;

class Program 
{
	public static void Main()
	{
		// 이미 C# 표준에 Math 있습니다.
		var ret = Math.Max(3.4, 2.1);
		var ret2 = Math.Sqrt(3);


		// 또다른 대표적인 static 클래스가 Console 입니다
		Console.WriteLine($"{ret}");

		//Console c = new Console(); // error


	}
}