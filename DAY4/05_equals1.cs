// 107 page ~  
class Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public Point(int a, int b) => (X, Y) = (a, b);
}

class Program
{
	public static void Main() 
	{		
		// �ٽ� : ���� ��ü �� ���� ����(�Ӽ�) �� ������ ������

		// p1, p2 �� "���� ��ü"
		Point p1 = new Point(1,2);
		Point p2 = p1;


		// p3, p4 �� "�ٸ� ��ü���� ���� ����"
		Point p3 = new Point(1,2);
		Point p4 = new Point(1,2);

		// �׻� ���ϼ��� �����Ҷ��� 
		// "��ü�� ���ϼ�" ���� "������ ���ϼ�" ������ �����ϼ���
	}
}
