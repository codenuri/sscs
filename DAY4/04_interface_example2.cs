using static System.Console;

// 핵심 : 사용자 정의 클래스에 크기 비교함수를 제공하고 싶다면
// => 되도록이면 C# 언어의 코딩 규칙을 따르세요!!
// => "IComparable" 인터페이스를 구현하세요

class Label : IComparable
{
	private string title;
	
	public Label(string s) => title = s;

    public int CompareTo(object? obj)
    {
		Label? other = obj as Label;

		// "d1.CompareTo(d2)" 에서 d2가 null 이면
		// d1이 무조건 크다고 반환.
		if (other == null)
			return 1;

		// title 은 string 타입인데.. string 타입 자체는
		// "ComapreTo" 가 이미 있습니다.
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

