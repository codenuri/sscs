using static System.Console;

class Program
{
	public static void Swap( int a, int b)
	{
		int temp = a;
		a = b;
		b = temp;
	}
	public static void Main()
	{
		int x = 1;
		int y = 2;

		// Swap �� ����� ������
		Swap( x, y );

		WriteLine($"{x}, {y}"); // 2, 1 ���;� �մϴ�.
	}
}