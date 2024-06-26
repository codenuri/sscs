// auto-implemented property
class Example
{
    // �ʵ� �Ѱ��� ����� Property�� ����� �������� �ڵ�� �Ʒ��� �����ϴ�
    private int data1 = 0;

    public int Data1 
    { 
        get { return data1; } 
        set { data1 = value; } 
    }

    // �� �ڵ忡�� set, get �� 
    // ��� �߰����� �������� ���� "�ʵ�"�� ���� R/W �ϰ� �ֽ��ϴ�.

    // �Ʒ� ������ �� �ڵ�� ������ �����մϴ�.
    // => �ʵ� �߰��ǰ�(�̸��� �˼� ����), setter, getter �߰�
    // => "auto implemented property" ��� �մϴ�.
    public int Data2 { set; get; } = 0;

}



class Program
{
    public static void Main()
    {

    }
}
