// Generic Ŭ����
// => Ŭ������ �ƴ� "Ŭ������ �����ϴ� Ʋ"
// => "Point<int>" �� ����ϸ� T=int �� Ŭ������ �����Ϸ��� ����
class Point<T>
{
    public string  name1 = null; // C# 9.0 ���� ���. 
    public string? name2 = null; // ok. null ���� ���� Ÿ��
    public string  name3 = null!; // ok. null ���� ���� �ƴ����� ���� �ʱ�ȭ�� null ���
    

    public T X { get; set; } = default(T)!;
    public T Y { get; set; } = default!;
}

class Program
{
    public static void Main()
    {
        Point<int> p = new Point<int>();
        p.X = 1;
        p.X = 2;
        Point<double> p1 = new Point<double>();

    }
}

