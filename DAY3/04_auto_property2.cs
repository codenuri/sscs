class Example
{
    private int data1 = 0;
	private int data2 = 0;

	// 필드를 직접 만든 프라퍼티(auto 가 아닌 경우)는 
	public int Data1 { set => data1 = value; }  // ok set-only 도 가능하고
    public int Data2 { get => data2;  }			// ok get-only 도 가능합니다
	

	// 아래 코드에서 에러는 ?
	public int Data3 { set; } = 0;	
	public int Data4 { get; } = 0;	


	public Example(int a, int b)
	{
		Data2 = a;	
		data2 = a;  
		Data4 = a;  
	}
}

class Program
{
    public static void Main()
    {
        Example e1 = new Example(1, 1);
	    e.Data2 = 10;	
		e.Data4 = 10;	

    }
}
