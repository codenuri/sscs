class Person
{
    private int age;

    // �Ʒ� �ڵ带 ���� �����Ϸ���
    // => set_Age(int value), get_Age() �޼ҵ带 ����
    public int Age
    {
        get { return age; }
        set { age = value; }    
    }

    // �Ʒ� �޼ҵ� �߰��ϰ� �����غ�����
    // => ���� �Դϴ�.
    // => Property �� ����ϸ� �̹� �Ʒ� �Լ��� �����ǹǷ�
    //    �̸� �浹
    // => Property �� ������ ����� �ֽ��ϴ�.
    public void set_Age(int a)
    {

    }
}

class Program
{
    public static void Main()
    {
        Person p1 = new Person();

        // Property �� ����
        p1.Age = 10;     // �����Ϸ��� p1.set_Age(10) ���� ����   

        int n = p1.Age;  // p1.get_Age() �� ����   
                            

        Console.WriteLine(n);

    }
}

// 1. ���ڵ� ������ ��������
// 2. ildasm �����ϼ���
//    (��������۹�ư => visual studio ���� => "Developer command prompt ����" ��
//     ��Ÿ���� â���� "ildasm.exe" ���� ����

// 3. ildasm ����  "DAY3.dll" ���� ������
//    => DAY3/bin/debug/net8.0/day3.dll 
