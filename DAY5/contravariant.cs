using static System.Console;

class Base
{
	public void Method() => WriteLine("Method");
}
class Derived : Base {}

delegate void MyAction<in T>(T obj);

class Program 
{
	public static void UseBase(Base b) { b.Method(); }
    public static void UseDerived(Derived d) { d.Method(); }

    public static void Main()
	{
		MyAction<Derived> f1 = UseDerived;

		// f1을 사용하려면 인자로 반드시 "Derived" 를 보내야 합니다.
		// 즉, f1 사용하는 모든 코드는 "Derived" 를 인자로 사용
		f1(new Derived());

		// f2는 Base를 인자로 요구.
		MyAction<Base> f2 = UseBase;


		f1 = f2;

    }
}