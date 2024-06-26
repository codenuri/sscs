class Example
{
    private int data1 = 0;
	private int data2 = 0;

	// 필드를 직접 만든 프라퍼티(auto 가 아닌 경우)는 
	public int Data1 { set => data1 = value; }  // ok set-only 도 가능하고
    public int Data2 { get => data2;  }			// ok get-only 도 가능합니다
	

	// 아래 코드에서 에러는 ?
//	public int Data3 { set; } = 0;	// error. 필드 이름을 모르는데
									// get 도 없다면
									// 꺼낼 방법이 없습니다.
									// auto 가 아니면 필드이름으로 꺼내면됩니다
	
	public int Data4 { get; } = 0;	// ok. set 이 없지만
									// 생성자에서는 사용가능.


	public Example(int a, int b)
	{
		// Data2 : get-only, 필드 이름 있음
		// Data4 : get-only, 필드 이름 모름.
//		Data2 = a;	// error.  필드이름 있으므로 아래 처럼 초기화 가능
		data2 = a;  // OK.

		Data4 = a;  // ok
	}
}

class Program
{
    public static void Main()
    {
        Example e1 = new Example(1, 1);
//	    e.Data2 = 10;	// error
//		e.Data4 = 10;	// error

    }
}
