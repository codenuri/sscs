class Program
{
    public static void M1(int a1) { }
    public static void M2(int a1, int a2) { }
    public static void M3(int[] ar) { }

    // C# �� �������� �޼ҵ�
    // => M4 �� M3 �� �����ϰ� �迭�� �䱸
    // => ��, M4(1,2,3) �� �����մϴ�.
	public static void M4(params int[] ar) { }

    public static void Main()
    {
        // #1. M2 ���� ���ڸ� 2���� ������ �մϴ�.
        M2(1, 2);    // ok
        M2(1, 2, 3); // error


        // #2. ������ ������ "����"���� �Ϸ��� �迭�� ������ �˴ϴ�.
        M3( new int[] { 1, 2, 3 } );  // int[] ar = new int[]{1,2,3} �̹Ƿ�
        M3( new [] { 1, 2, 3 } );     // int[] ar = new []{1,2,3} 
//      M3( { 1, 2, 3 } );            // int[] ar = {1,2,3} 
                                      // �� ǥ����� ����!!

        M3( [ 1, 2, 3 ] );            // ok. C# 12 ����.. 

        // #3. �Ʒ� ó�� ����Ҽ� ������� ?
        M3(1, 2, 3); // error. M3 �� "�迭"�� �䱸 �մϴ�.

        // #4. ���� ���� �޼ҵ� ���
        M4(new int[] { 1, 2, 3 });
        M4(1, 2, 3); // ok!! �ٽ�
                     // 1,2,3 �� �����Ϸ��� "new int[]{1,2,3}" ���κ���
    }







    // ���� ����
//  public static void M5(int[] ar, int n) { }			
//	public static void M6(params int[] ar, int n) { }	

}
	