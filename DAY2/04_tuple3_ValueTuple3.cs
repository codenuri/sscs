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

    // public (int, int) Get() // ok
    public (int x, int y) Get() // ok
    {
		return (x, y);
	}
}
class Program 
{
	public static void Main()
	{
		Point p = new Point(1,2);

		var ret = p.Get(); // ret �� (int, int) Ÿ���Դϴ�.
		WriteLine($"{ret.Item1}, {ret.Item2}");
        WriteLine($"{ret.x}, {ret.y}");


        var ret1       = p.Get(); // ��ȯ����� tuple �� ���� ��
		(int x, int y) = p.Get(); // ��ȯ ����� deconstruction �ؼ�
                                  // int 2�� ������ ������

        WriteLine($"{x}, {y}");
    }
}
