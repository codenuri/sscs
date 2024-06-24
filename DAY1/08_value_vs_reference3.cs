using static System.Console;

class CPoint
{
    public int x;
    public int y;
    public CPoint(int a, int b) { x = a; y = b; }
}
struct SPoint
{
    public int x;
    public int y;
    public SPoint(int a, int b) { x = a; y = b; }
}
class Program
{
    public static void Main()
    {
        // value_reference2.cs ������ ������
        // �Ʒ� �ڵ忡 ���� �׸��� "28page ������" �׸��Դϴ�.

        CPoint cp1; // ��ü ���� �ȵ�. reference(������)�� �����
        SPoint sp1; // ��ü ���� ��. ��, ������ ȣ��ȵ�.
        SPoint sp2 = new SPoint(1, 1); // ��ü �����ǰ�, 
                                       // ������ ȣ���. 

        cp1.x = 1;      // error. ��ü�� ����.

        int n1 = sp1.x; // error. �ʱ�ȭ���� ���� ������ �д� �ڵ�
        sp1.x = 1;      // ok..�ʱ�ȭ���� �ʾƵ� ����� ����.

        int n2 = sp2.x; // ok


        int a1;     // �ʱ�ȭ �ȵ�
        int a2 = 0; // int a2 = new int()�� �ǹ� �ʱ�ȭ��.
    }
}

