using static System.Console;

/*
// ��ü�� �ڽŰ� �����ϰ� ���� ���纻�� ����� �۾���
// ���� ���Ǵ� �۾��Դϴ�.
// �޼ҵ� �̸��� �������̽��� ����մϴ�.
interface ICloneable
{
    Object Clone();
}

// �迭�� ���������� �����մϴ�.
class Int32[] : ICloneable 
{
    public Object Clone()
    {
        // �ڽŰ� ������ ��Ҹ� ������ �迭�� �Ѱ� �������ؼ�
        //  ��ȯ�մϴ�.
    }
}
*/


class Program
{
    public static void Main()
    {
        int n1 = 0;
        int[] arr = { 1, 2, 3 };

        // Ÿ�� ����� ���� ������. ���� ���� ���� ���� ������ Ÿ���Դϴ�.
        // n1  : int
        // arr : int[]


        int[] arr1 = { 1, 2, 3 };

        int[] arr2 = arr1; // arr2 �� arr1 �� ���� �迭 ����

//      int[] arr3 = arr1.Clone(); // arr1 �� ������ �迭�� �Ѱ� �������ؼ�
                                            // arr3�� ����Ű�ڴٴ� �ǵ�

        // �� �ڵ�� �� ���� �ϱ�� ?
        // �ذ�å�� ?
        int[] arr3 = (int[])arr1.Clone();
    }
}

