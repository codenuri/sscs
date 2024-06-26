
// auto implemented property vs public �ʵ�

class Person
{
    //    public string Name { get; }   // setter ����. 
                                        // ��, �����ڿ����� set ����

    public string Name { get; private set; } // setter ������ private
                                        // �ڽ��� ��� �޼ҵ� ������ ��밡��
                                        // �ܺο����� ���� �ȵ�.


    public string Address { get; set; }

    public Person(string name, string address)
    {
        Name = name;        
        Address = address;
    }
}

class Program
{
    public static void Main()
    {
        Person p = new Person("kim", "seoul");

        string s = p.Name;   

        p.Address = "seoul";
    }
}

// �߰�������
// �Ӽ����� �����
// "��ü�� ���� ��� �Ӽ��� �ڵ����� �����ؼ� ����� �ִ� ���̺귯������ �ֽ��ϴ�.
// "Name, Address" �� �ʵ�� ����� �̷� ����� ����Ҽ� �����ϴ�.

// DataGrid g = new DataGrid();
// g.Add(p); // p�� ���� �Ӽ��� ��� ���� �ڵ����� �����ִ� ���