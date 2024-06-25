using static System.Console;

class Program
{
	// ������ ������ ����� ��ȯ�ϴ� �޼ҵ�
	public static int AddSub1(int a, int b, ref int n)
	{
		n = a - b;
		return a + b;
	}

    public static int AddSub2(int a, int b, out int n)
    {
        n = a - b;
        return a + b;
    }

    public static void Main()
	{
//		int ret1 = 0;
        int ret1;       // �ʱ�ȭ �ȵ�.

//      int ret2 = AddSub1(5, 3, ref ret1); // error. ref ������
                                            // �ʱ�ȭ�� ������ ����
                                            // ��, �Լ� �ȿ��� R/W�ϰڴٴ� �ǵ�


        int ret2 = AddSub2(5, 3, out ret1); // ok. �ʱ�ȭ ���� ���� ���ڵ� ����

        // C#7.0 ���� out �Ķ���ʹ� ���� ���� ������ ���� ���� �����������ϴ�.

        int ret3 = AddSub2(5, 3, out int x); // ok. x �� ���� ��ü�� ���� �ȿ�ǥ��

        WriteLine($"{ret1} {ret2}");
	}
}