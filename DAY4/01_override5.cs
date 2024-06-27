using static System.Console;

// 1. non-virtual 은 파생 클래스에서 되도록 다시 만들지 마세요

// 2. 파생 클래스가 다신 만들수 있게 하려면 virtual 로 하세요
//    파생 클래스가 override 할때는 "new" 도 가능하지만 되도록 하지 마세요!!
//												(나쁜 디자인)
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
								// 사용하지 마세요. 혼란의 원인
}

class Program 
{
	public static void Main()
	{
		Base b = new Derived();
		b.M1(); //

		b.M3(); // Derived M3
		b.M4(); // Base M4
	}
}