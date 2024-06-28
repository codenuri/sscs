using static System.Console;

// covariant (공변성) - 어렵습니다.

class Base
{
	public void Method() => WriteLine("Method");
}
class Derived : Base 
{	
}

// 핵심 
// 1. Derived 는 Base 로 부터 모든 기능을 물려받는다.
// 2. 따라서 Base 객체가 필요할때 "Derived 객체" 를 사용해도 된다.

delegate R MyFunc<out R>();

class Program 
{
    public static Base CreateBase()       { return new Base(); }
    public static Derived CreateDerived() { return new Derived(); }

	public static void Main()
	{	
		MyFunc<Base>    fbase = CreateBase;
        MyFunc<Derived> fderived = CreateDerived;

        // fbase 를 사용하는 것은 결국 "Base객체를 얻기위해서 입니다."
        Base b = fbase();
		b.Method();

        // 아래 한줄이 논리적으로 되어야 할까요 ? 안되야 할까요 ?
        // fbase    : Base 객체는 얻는 함수를 담은 델리게이트
        // fderived : Derived 객체는 얻는 함수를 담은 델리게이트
        fbase = fderived;   // out 이 없으면 안됩니다.
                            // out 이 있으면 이변환이 허용됩니다.
	}
}
