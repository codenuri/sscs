using System;
using static System.Console;

class Train
{
	// 1��°���� ��ü�� ����� �ð�
    private static DateTime startTime;

	// �ð��� ���ڿ��� ��ȯ�ϴ� �޼ҵ�
	public  static string FirstTrainStartTime()
		=> startTime.ToLongTimeString();


	public int Color;
	public int Speed;

	// �Ʒ� ó�� �Ϲ� �����ڿ��� �ʱ�ȭ �ϸ�
	// "���� ��ü�� ���鶧 ���� startTime" �� ����˴ϴ�.
//	public Train() { startTime = DateTime.Now; }


	// �Ʒ� ó�� static �����ڿ��� �ʱ�ȭ�ϸ�
	// "1��° ���� ���� ��ü�� �ð����� �ʱ�ȭ �Ǽ�"
	// ��� ��ü�� �ش� �ð��� ���� �Ҽ� �ֽ��ϴ�.
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