using static System.Console;

class Animal
{
    // non-virtual : static binding, ���������� Ÿ������ ȣ�� ����
    public void Cry1() { WriteLine("1. Animal Cry1"); }

    // virtual method : dynamic binding, ������ ����Ű�� ���� ��ü�� �޼ҵ�ȣ��
    public virtual void Cry2() { WriteLine("1. Animal Cry2"); }
}

class Dog : Animal
{
    public new void Cry1() { WriteLine("2. Dog Cry1"); }

    // virtual method �� override �Ҷ��� "override" ����� �մϴ�.
    public override void Cry2() { WriteLine("2. Dog Cry2"); }
}

class Program
{
    public static void Main()
    {
        Animal a = new Dog();

        a.Cry1();   // non-virtual static binding, Animal Cry1
                    
        a.Cry2();   // virtual  dynamic binding    Dog Cry2
    }
}

