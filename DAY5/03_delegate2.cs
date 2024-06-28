using System;
using static System.Console;


// #1. delegate1.cs �� ���ؼ� "delegate ����� ��" �˾� �μ���

// #2. ��Ȯ�� ����

delegate void MyFunc(int arg);

/*
// �� ������ ���� �����Ϸ��� �Ʒ� Ŭ���� ����
class MyFunc : MulticastDelegate
{
    // void�� ��ȯ�ϰ� ���ڰ� int �Ѱ��� �޼ҵ��� �ּ� �����ߴٰ�
    // ȣ���ϱ� ���� �ڵ带 �ڵ�����
    // Invoke() ���� �޼ҵ嵵 �߰���
}
*/


class Program
{
    public static void Foo(int arg) { WriteLine($"Foo : {arg}"); }

    public static void Main()
    {
        // #3. �ᱹ MyFunc �� Ŭ���� �Դϴ�.
        MyFunc f1 = new MyFunc(Foo); // delegate �� ����ϴ� ��Ȯ�� ǥ���
        MyFunc f2 = Foo;             // ���� ǥ����� �����ϴ� ��!

        // #4. delegate ��ü�� �޼ҵ� ȣ���ϱ�
        f2(10);         // () ������ ���
        f2.Invoke(10);  // �̷��Ե� ����
    }


}
