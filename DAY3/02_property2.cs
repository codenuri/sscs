// property(�Ӽ�) : setter �� getter �� ���� ����� ����

class Person
{
    private int age;

    // �Ʒ� �ڵ尡 "property" ������ �⺻ �ڵ��Դϴ�
    public int Age
    {
        get { return age; } 
        set { age = value; }    // value �� �� ��ġ������ ��밡���� Ű�����Դϴ�.
                                // "context keyword" ��� �մϴ�.
                                // Ư�� ��ġ������ ��밡���� Ű����
    }
}

class Program
{
    public static void Main()
    {
        Person p1 = new Person();

        p1.Age = 10;        // �̼��� set �κ� ����
                            // value ���� 10 ���� 

        int n = p1.Age;     // �̼��� get �κ� �����

        Console.WriteLine(n);

    }
}
