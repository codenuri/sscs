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

		// f1�� ����Ϸ��� ���ڷ� �ݵ�� "Derived" �� ������ �մϴ�.
		// ��, f1 ����ϴ� ��� �ڵ�� "Derived" �� ���ڷ� ���
		f1(new Derived());

		// f2�� Base�� ���ڷ� �䱸.
		MyAction<Base> f2 = UseBase;


		f1 = f2;

    }
}