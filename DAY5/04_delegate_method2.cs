using static System.Console;

delegate void MyFunc(int arg);

class Program
{
    public static void SMethod(int arg) => WriteLine("SMethod");
    public        void IMethod(int arg) => WriteLine("IMethod");

    public static void Main()
    {
		// #1. 앞의 예제는 "다른 클래스의 메소드를 등록하는 예제"

		// #2. 이번에는 자신의 static, instance method 이야기

		// 먼저 직접 호출
		Program.SMethod(1);





		MyFunc f1 = Program.SMethod; // ?
		MyFunc f2 = SMethod;		 // ?
		MyFunc f3 = IMethod;		 // ?

		p.InstanceMethod();
	}

	public void InstanceMethod()
	{
	}
}
