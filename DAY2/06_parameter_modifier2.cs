using static System.Console;

class Program
{
	// ������ ������ ����� ��ȯ�ϴ� �޼ҵ�
	public static int AddSub(int a, int b, ref int n)
	{
		n = a - b;

		return a + b;
	}

	public static void Main()
	{
		int ret1 = 0;

		int ret2 = AddSub(5, 3, ref ret1);

		WriteLine($"{ret1} {ret2}");
	}
}