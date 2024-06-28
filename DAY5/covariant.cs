using static System.Console;

// covariant (������) - ��ƽ��ϴ�.

class Base
{
	public void Method() => WriteLine("Method");
}
class Derived : Base 
{	
}

// �ٽ� 
// 1. Derived �� Base �� ���� ��� ����� �����޴´�.
// 2. ���� Base ��ü�� �ʿ��Ҷ� "Derived ��ü" �� ����ص� �ȴ�.

delegate R MyFunc<out R>();

class Program 
{
    public static Base CreateBase()       { return new Base(); }
    public static Derived CreateDerived() { return new Derived(); }

	public static void Main()
	{	
		MyFunc<Base>    fbase = CreateBase;
        MyFunc<Derived> fderived = CreateDerived;

        // fbase �� ����ϴ� ���� �ᱹ "Base��ü�� ������ؼ� �Դϴ�."
        Base b = fbase();
		b.Method();

        // �Ʒ� ������ �������� �Ǿ�� �ұ�� ? �ȵǾ� �ұ�� ?
        // fbase    : Base ��ü�� ��� �Լ��� ���� ��������Ʈ
        // fderived : Derived ��ü�� ��� �Լ��� ���� ��������Ʈ
        fbase = fderived;   // out �� ������ �ȵ˴ϴ�.
                            // out �� ������ �̺�ȯ�� ���˴ϴ�.
	}
}
