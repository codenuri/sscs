// 27page ~ 
using static System.Console;

// #1. CPoint �� SPoint �� �̸��� �����ϸ� ������ �����մϴ�.
// #2. ��, CPoint �� class, SPoint �� struct �Դϴ�

class CPoint
{
	private int x;
	private int y;
	public CPoint(int a, int b) { x = a; y = b;}
}
struct SPoint
{
	private int x;
	private int y;
	public SPoint(int a, int b) { x = a; y = b;}	
}
class Program 
{
	public static void Main()
	{
		// �Ʒ� �ڵ�� ��ü�� �����ϴ� ����� ������ �����մϴ�.
		// => �׷��� �޸� ������ ������ �ٸ��ϴ�.
		// => ���� 27 page ���� �׸�
		CPoint cp = new CPoint(0, 0);
        SPoint sp = new SPoint(0, 0);




		int n1 = 0;         // new int() �ε� struct �Դϴ�.
		string s1 = "ABCD"; // new string("ABCD") �ε� class�Դϴ�


		// �迭�� "�� Ÿ��" �ϱ��? "���� Ÿ��" �ϱ�� ?
		// C# : reference type.  �迭 ��ü�� "��" �ְ�,
		//	    arr�� ���� �ִ� ����Ÿ�� ����Ű�� ���۷���(�ּ�)

		// swift : value type ���� �����. �迭 ��ü�� "stack" �� ����
		//         �迭�� �Ҵ�/������ C# ���� ����. 

		int[] arr = { 1, 2, 3, 4, 5 };


		// ��¥�� �ð��� �ٷ�� Ÿ���Դϴ�.
		// => value type �ϱ�� ? reference type �ϱ�� ?
		DateTime tm = new DateTime(2024, 1, 1);
	}
}
