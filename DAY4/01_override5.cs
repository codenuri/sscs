using static System.Console;

// 1. non-virtual 은 파생 클래스에서 되도록 다시 만들지 마세요

class Base
{
	public void M1() {}

	public virtual void M3() { WriteLine("Base M3");}
	public virtual void M4() { WriteLine("Base M4");}	
}
class Derived : Base 
{
    public void M1() { }     // ok. new 없다고 경고!
    public new void M1() { } // ok. 하지만 나쁜 코드 되도록 사용하지 마세요
    public override void M1() { } // error

    // virtual 함수를 다시 만들때 "override" "new" 모두 가능합니다.
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