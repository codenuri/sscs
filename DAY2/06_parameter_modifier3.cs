using static System.Console;

class Program
{
	// modifier 없는 경우
	// => 인자의 복사본 x 생성
	// => 내부적으로 R/W 모두 가능
	public static void no_modifier_parameter(int x)
	{
		int n = x; // ok. read
		x = 0;     // ok. write
	}

	public static void out_parameter(out int x)
	{
//		int n = x;	// error. out parameter 는 초기화 되지 않은 변수를
					// 가리킬수도 있다. 담기만 하겠다는 의도 이므로 
					// 읽을수 없다.

//		x = 0;		// ok. Write 는 가능
					// 단, 이 코드(쓰는 코드)가 없다면 에러!

	}

	public static void ref_parameter(ref int x)
	{
		// R/W 모두 가능. R/W 가 모두 없어도 가능
		int n = x;	 // ok
		x = 0;		 // ok
	}

	public static void Main()
	{
		int n1;
		int n2 = 0;

		no_modifier_parameter(n2);

		out_parameter(out n1); // ok  초기화 안되도 전달 가능.
		out_parameter(out n2); // ok
        out_parameter(out int n3); // ok. 이렇게도 가능

        ref_parameter(ref n1);	// error. 초기화 된것만 가능
								// 내부적으로 R/W 를 모두 하겠다는 의도

		ref_parameter(ref n2);	// ok

		

	}
}