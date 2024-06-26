class Example
{
    private int data1 = 0;
	private int data2 = 0;

	// �ʵ带 ���� ���� ������Ƽ(auto �� �ƴ� ���)�� 
	public int Data1 { set => data1 = value; }  // ok set-only �� �����ϰ�
    public int Data2 { get => data2;  }			// ok get-only �� �����մϴ�
	

	// �Ʒ� �ڵ忡�� ������ ?
//	public int Data3 { set; } = 0;	// error. �ʵ� �̸��� �𸣴µ�
									// get �� ���ٸ�
									// ���� ����� �����ϴ�.
									// auto �� �ƴϸ� �ʵ��̸����� ������˴ϴ�
	
	public int Data4 { get; } = 0;	// ok. set �� ������
									// �����ڿ����� ��밡��.


	public Example(int a, int b)
	{
		// Data2 : get-only, �ʵ� �̸� ����
		// Data4 : get-only, �ʵ� �̸� ��.
//		Data2 = a;	// error.  �ʵ��̸� �����Ƿ� �Ʒ� ó�� �ʱ�ȭ ����
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
