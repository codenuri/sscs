// 75 page ~ 
using static System.Console;

// interface : Ŭ������ ���Ѿ� �ϴ� ��Ģ(�޼ҵ��̸�)�� ���� �ϴ� ���� 

// �ٽ� #1. C# ���� �������̽��� ����� ���
interface FirstGroup
{
	// �� �ȿ� �޼ҵ� ���� ����.
	// public, virtual ���� ǥ������ �ʰ�, �����ε� ����
	void M1();
	int M2(int arg);
}

// #2. �������̽����� ���� ��Ģ�� �������� "���" ǥ������
// => Example �� "FirstGroup" ��Ģ�� ��Ű�ڴٴ� �ǹ�
class Example : FirstGroup
{
	// #3. Example Ŭ������ �ݵ�� FirstGroup �������̽����� �����
	//     �޼ҵ带 �����ؾ� �Ѵ�.
	public void M1() { }
	public int M2(int arg) { return 0; }
}

class Program 
{
	public static void Main()
	{
		// #4. interface �� ��ü�� �����Ҽ� �����ϴ�.
		FirstGroup g = new FirstGroup();

		// #5. ������ interface Ÿ���� �����μ��� ��밡���մϴ�.
		FirstGroup g2 = new Example(); // ok
		 
		// ��, interface �� ��ü�� ����� ������
		// ���� �����δ� ��밡���մϴ�.
		
	}
}
