using static System.Console;

class Point
{
	public int x = 0;
	public int y = 0;

	public Point(int a, int b)
	{
		// �Ʒ� ó�� �ۼ��ϸ� 2���� �ʿ� �մϴ�.
		//x = a;
		//y = b;

		// �Ʒ� ó���Ҽ��� �ֽ��ϴ�.
		// => tuple deconstruction ���
		(x, y) = (a, b);

		// �Ʒ� �ڵ�� �� �����ϼ���.
		// => tuple �� ������ ������ �ֽ��ϴ�
		//(int x, int y) t1 = (a, b);
	}

    // �Ϲ������� �޼ҵ��� ��ȯ���� �Ѱ� �Դϴ�.
    // => ������ tuple �� ��ȯ�ϸ� 2�� �̻� ��ȯ �����մϴ�.
    // public var Get()	// error. var �� ���� �ڸ��� ����Ҽ� �����ϴ�
    // public ValueTuple<int, int> Get() // ok

    public (int, int) Get() // ok
    {
		return (x, y);
	}
}


class Program 
{
	public static void Main()
	{
		Point p = new Point(1,2);
	}
}
