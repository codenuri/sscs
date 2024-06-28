using static System.Console;


// C# 1.0 : Generic ������ �������ϴ�.
interface IComparable
{
    int CompareTo(object obj);
}

// C# 2.0 : Generic ������ ���ԵǾ����ϴ�
interface IComparable<T>
{
    int CompareTo(T obj);
}


// ��� : ����� Ŭ������ CompareTo ���� �޼ҵ带 �������
// 1. �������̽��� ���� ǥ���ϰ� ���弼��
// 2. IComparable �������̽��� �����ϸ� ���ڰ� object �̾�� �մϴ�.
// 3. IComparable<T> ������ ����ϸ� ��Ȯ�� Ÿ������ �Ҽ� �����Ƿ�
//    Boxing ���� ������尡 �������ϴ�.

// ���� : IComparable<Digit>, IComparable �� ��� ����!!
// ��, CompareTo �� 2�� ������ �ǹ�..

struct Digit : IComparable<Digit>, IComparable
{
    public int Value { get; set; }

    public Digit(int n) => Value = n;

 
    public int CompareTo(Digit other)
    {
        return Value.CompareTo(other.Value);
    }

    public int CompareTo(object other)
    {
        Digit obj = (Digit)other;

        return Value.CompareTo(obj.Value);
    }
}

class Program
{
    public static void Main()
    {
        Digit d1 = new Digit(3);
        Digit d2 = new Digit(4);

        int ret = d1.CompareTo(d2); // object �� �ƴ� Digit ���� ȣ��
                                    // Boxing ����, ������� ����

        Foo(d1); // ok.  "IComparable" �������̽��� ȣȯ��
    }

    public static void Foo(IComparable ic)
    {

    }
}


