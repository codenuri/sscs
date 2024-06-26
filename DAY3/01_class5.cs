using static System.Console;

class Point3D
{
    private int x, y, z;

    public Point3D(int a, int b, int c)
        => (x, y, z) = (a, b, c);

    // Deconstruct �� �����ε� �����մϴ�.(������ ����� �ִٴ� �ǹ�)
    public void Deconstruct(out int a, out int b, out int c)
        => (a, b, c) = (x, y, z);

    public void Deconstruct(out int a, out int b)
        => (a, b) = (x, y);

    public void Deconstruct(out int a)
        => a = x;

}

class Program
{
    public static void Main()
    {
        Point3D p = new Point3D(1, 2, 3);

        (int a1, int a2, int a3) = p;
//      p.Deconstruct(out int a1, out int a2, out int a3);

        (int b1, int b2) = p;

        // �Ѱ��� ���� ���� ȣ���ؾ� �մϴ�.
  //      int c1 = p; // error
  //      p.Deconstruct(out int c); // ok

        // ������ 
        // => ��ȯ ������ �Լ����� �浹�� ���ϱ� ���ؼ� �Դϴ�.
//        int c1 = p; // �� ���� Point3d => int �� �����ϴ�
                    // ��ȯ������ �Լ� ȣ��˴ϴ�.
                    // ����, Deconstruct ���� �浹 ���ɼ� ������
                    // �� �ڵ尡 �ȵ˴ϴ�.

        WriteLine($"{a1}, {a2}, {a3}");
    }
}