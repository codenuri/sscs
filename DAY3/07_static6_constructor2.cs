using System;
using static System.Console;

class Train
{
	// 1번째열차 객체가 출발한 시간
    private static DateTime startTime;

	// 시간을 문자열로 반환하는 메소드
	public  static string FirstTrainStartTime()
		=> startTime.ToLongTimeString();


	public int Color;
	public int Speed;

	// 아래 처럼 일반 생성자에서 초기화 하면
	// "기차 객체를 만들때 마다 startTime" 이 변경됩니다.
//	public Train() { startTime = DateTime.Now; }


	// 아래 처럼 static 생성자에서 초기화하면
	// "1번째 만든 기차 객체의 시간으로 초기화 되서"
	// 모든 객체가 해당 시간을 공유 할수 있습니다.
	static Train() { startTime = DateTime.Now;}
}

class Program 
{
	public static void Main()
	{
		Train t1 = new Train();
		WriteLine($"{Train.FirstTrainStartTime()}");

		Train t2 = new Train();
		WriteLine($"{Train.FirstTrainStartTime()}");
	}
}