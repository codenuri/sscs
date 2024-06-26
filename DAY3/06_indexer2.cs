class Example
{
    // 필드는 없지만 항상 0을 반환하는 속성
	public int Data1 { get => 0;}    

    // 아래 main 이 에러나오지 않게 이 부분 만들어 보세요.
}

class Program
{
    public static void Main()
    {
        Example e = new Example();

        int n1 = e.Data1; // 0

        int n2 = e[0];
        int n3 = e["A"];
        int n4 = e[0, 1];
        int n5 = e[0, "A"];
    }
}