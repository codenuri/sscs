using static System.Console;

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry"); }
}
class Dog : Animal
{
    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Program
{
    public static void Main()
    {
        Animal a = new Animal();    a.Cry();  // Animal Cry
        Dog    d = new Dog();       d.Cry();  // Dog Cry

        Animal a2 = new Dog();

        a2.Cry();   // ��ü�� Dog, ���� ������ Animal
                    // C#�� 1 ? 2 �� ��� ���� ȣ��ɱ�� ?
                    // 1 ? 2 �� ��� ���� ȣ���ϴ� ���� �������� ������� ?
    }
}

