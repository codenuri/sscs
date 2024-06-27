using static System.Console;

//class Point 
struct Point
{
	public int X{set; get;} = 0;
	public int Y{set; get;}	= 0;

	public Point(int a, int b) => (X, Y) = (a, b);
}

class Program
{
	public static bool MyReferenceEquals(object a, 
										 object b)
	{
		return a == b;
	}

	public static void Main()
	{
		// Point �� Value Type
		Point p = new Point(1, 1);

		// #1. ValueType �� == ���� �ȵ˴ϴ�.
        // p == p; // error

        WriteLine($"{MyReferenceEquals(p, p)}");
						// ���� ��ü�� �������� ����� False �Դϴ�.
						// Boxing ������ �����鼭 ���� ���纻 ����
						// 2���� ���纻�� ���ϰ�ü�� �ƴϹǷ� False


//		WriteLine($"{object.ReferenceEquals(p, p)}");

    }
}