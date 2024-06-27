using static System.Console;

// �ٽ� : ����� ���� Ŭ������ ũ�� ���Լ��� �����ϰ� �ʹٸ�
// => �ǵ����̸� C# ����� �ڵ� ��Ģ�� ��������!!
// => "IComparable" �������̽��� �����ϼ���

class Label : IComparable
{
	private string title;
	
	public Label(string s) => title = s;

    public int CompareTo(object? obj)
    {
		Label? other = obj as Label;

		// "d1.CompareTo(d2)" ���� d2�� null �̸�
		// d1�� ������ ũ�ٰ� ��ȯ.
		if (other == null)
			return 1;

		// title �� string Ÿ���ε�.. string Ÿ�� ��ü��
		// "ComapreTo" �� �̹� �ֽ��ϴ�.
        return title.CompareTo(other.title);
    }
}

class Program 
{
	public static void Main()
	{
		Label d1 = new Label("GOOD");
		Label d2 = new Label("BAD");

		int ret = d1.CompareTo(d2);

		
	}

	public static void Foo(IComparable ic)
	{
	}
}

