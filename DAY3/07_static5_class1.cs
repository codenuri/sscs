using static System.Console;

// ���а��� �Լ��� ���̺귯���� �����ϰ� �ʹ�.
// => C���� "����� �ƴ� �Ϲ� �Լ�" ��� ���� ����� ������
// => C#�� ��� ���� Ŭ�����θ� ����� �ִ�.
// => "top level programming" �� �ᱹ Main �Լ������� �̵��ϴ� ��

// #1. �Ʒ� ó�� �Ϲ�(����� �ƴ�) �Լ��� ����� �����ϴ�.
/*
int Max(int a, int b)
{
	return a < b ? b : a;
}

int Square(int x)
{
	return x * x;
}
*/

// #2. Ŭ������ ������ �մϴ�.
// Date, Person, Point, Rect : ����(�ʵ�)�� �����Ƿ� ��ü�� �����ؼ� �����ؾ��մϴ�.
// Math : ����, ���а��� �޼ҵ带 �����һ�, ����� ����Ÿ�� �����ϴ�.
//        ��� �޼ҵ带 static ���� �ϴ� ���� ���մϴ�.

// static class : ��� ����� static �� Ŭ����
//                ��ü�� �����Ҽ� ���� �ϱ� ���� ���.
//                Math �� static ���� ���ص� ������, �����ϰ� �ϱ� ���ؼ���
//                static class �� ���� �ϴ� ���� ����.
static class Math
{
    public static int Max(int a, int b)
    {
        return a < b ? b : a;
    }

    public static int Square(int x)
    {
        return x * x;
    }
}

class Program 
{
	public static void Main()
	{
        int n = Math.Square(2);

//        Math m = new Math();
	}
}