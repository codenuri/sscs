using static System.Console;

class Test
{
    public static void SMethod(int arg) 	
		=> WriteLine("Test.SMethod");

    public void IMethod(int arg)
		=> WriteLine("Test_Object.IMethod");
}

delegate void MyFunc(int arg);

class Program
{
    public static void Main()
    {
        // �Ʒ� �ּ��� �׻� �����ϼ���
        // static method   : Ŭ���� �̸����� ȣ��. ��ü ��� �˴ϴ�.
        // instance method : ��ü�̸��� ȣ��. �ݵ�� ��ü�� �����Ǿ�� ȣ�Ⱑ��

        // �ٽ� : delegate �� method �� ����ϴ� ���

        MyFunc f1 = SMethod;
        MyFunc f2 = IMethod;

    }
}
