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

}

class Program 
{
	public static void Main()
	{
				
	}
}
