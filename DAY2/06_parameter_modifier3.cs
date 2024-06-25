using static System.Console;

class Program
{
	// modifier ���� ���
	// => ������ ���纻 x ����
	// => ���������� R/W ��� ����
	public static void no_modifier_parameter(int x)
	{
		int n = x; // ok. read
		x = 0;     // ok. write
	}

	public static void out_parameter(out int x)
	{
//		int n = x;	// error. out parameter �� �ʱ�ȭ ���� ���� ������
					// ����ų���� �ִ�. ��⸸ �ϰڴٴ� �ǵ� �̹Ƿ� 
					// ������ ����.

//		x = 0;		// ok. Write �� ����
					// ��, �� �ڵ�(���� �ڵ�)�� ���ٸ� ����!

	}

	public static void ref_parameter(ref int x)
	{
		// R/W ��� ����. R/W �� ��� ��� ����
		int n = x;	 // ok
		x = 0;		 // ok
	}

	public static void Main()
	{
		int n1;
		int n2 = 0;

		no_modifier_parameter(n2);

		out_parameter(out n1); // ok  �ʱ�ȭ �ȵǵ� ���� ����.
		out_parameter(out n2); // ok
        out_parameter(out int n3); // ok. �̷��Ե� ����

        ref_parameter(ref n1);	// error. �ʱ�ȭ �Ȱ͸� ����
								// ���������� R/W �� ��� �ϰڴٴ� �ǵ�

		ref_parameter(ref n2);	// ok

		

	}
}