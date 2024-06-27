using static System.Console;

class Animal
{
    // non-virtual : static binding, 참조변수의 타입으로 호출 결정
    public void Cry1() { WriteLine("1. Animal Cry1"); }

    // virtual method : dynamic binding, 참조가 가리키는 실제 객체의 메소드호출
    public virtual void Cry2() { WriteLine("1. Animal Cry2"); }
}

class Dog : Animal
{
    public new void Cry1() { WriteLine("2. Dog Cry1"); }

    // virtual method 를 override 할때는 "override" 적어야 합니다.
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

