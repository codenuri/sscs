using static System.Console;

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry"); }
}

class Dog : Animal
{
    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Cat : Animal
{
    public new void Cry() { WriteLine("3. Cat Cry"); }
}


class Program
{
    public static void Main()
    {
        // 73page.
        // �ٽ� #1. ����� �Է¿� ���� �ٸ� ��ü�� �������
        //          ������ Animal Ÿ������ �ؾ� �մϴ�.
        Animal a; 

        int n = int.Parse( Console.ReadLine() ?? "0");

        if ( n == 1 )
            a = new Dog();
        else
            a = new Cat();

        // �ٽ� #2. �����Ϸ��� �Ʒ� �ڵ带 ������ �Ҷ�
        // 1. a�� ����Ű�� ���� � ����(Dog, Cat) �� ��ü�� �ִ��� �˼� �����ϴ�.
        //    => ����ð� �Է� ���� ���� �����ǹǷ�
        // 2. �����Ϸ��� �ƴ� ���� "a��� ���� ��ü�� Animal Ÿ��" �̶�� ��!!
        a.Cry();
    }
}

// a.Cry() �� � �Լ��� �����Ұ��ΰ� ?
// => �Լ� ���ε�(function binding) �̶�� �մϴ�.

// �ٽ� #3. �Լ� ���ε��� ���� ( 73page)

// 1. static binding : 


// 2. dynamic binding : 

