using static System.Console;

// 1. non-virtual �� �Ļ� Ŭ�������� �ǵ��� �ٽ� ������ ������

class Base
{
	public void M1() {}

	public virtual void M3() { WriteLine("Base M3");}
	public virtual void M4() { WriteLine("Base M4");}	
}
class Derived : Base 
{
    public void M1() { }     // ok. new ���ٰ� ���!
    public new void M1() { } // ok. ������ ���� �ڵ� �ǵ��� ������� ������
    public override void M1() { } // error

    // virtual �Լ��� �ٽ� ���鶧 "override" "new" ��� �����մϴ�.
    public override void M3() { WriteLine("Derived M3"); }
    public new void M4()      { WriteLine("Derived M4"); }
}

class Program 
{
	public static void Main()
	{
		Base b = new Derived();
		b.M1(); //

		b.M3(); 
		b.M4();
	}
}