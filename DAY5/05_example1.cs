using static System.Console;

class Program 
{
	public static void Main()
	{
		int[] x = { 1, 8, 6, 4, 3 };

		// Array : �迭���� �پ��� static method �� �����ϴ� Ŭ����
		// => �迭 ���� � ����� �ʿ��ϸ� "Array"���� ã������

		// #1. �迭���� "3"�� �ִ� ��ġ�� ã�� �ʹ�. �� �˻�
		int ret1 = Array.IndexOf(x, 3);
		WriteLine($"{ret1}"); // 4


        // #2. �迭���� ó�� ������ "¦��"�� ã�� �ʹ�. ���ǰ˻�
        int ret2 = Array.FindIndex(x, �޼ҵ�);
        WriteLine($"{ret2}"); 
    }

}