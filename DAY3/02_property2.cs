// property(�Ӽ�) : setter �� getter �� ���� ����� ����

class Person
{
    private int age;

    // �Ʒ� �ڵ尡 "property" ������ �⺻ �ڵ��Դϴ�
    public int Age
    {
        get { return age; } 
        set { age = value; }
    }
}



class Program
{
    public static void Main()
    {
        Person p1 = new Person();

        p1.SetAge(-10);

    }
}
