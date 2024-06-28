using static System.Console;

delegate void Handler(Button source);

class Button
{
    public Handler Click = null; // ��ư�� ������ ȣ��� �Լ����

    public void UserPressButton()
    {
        Click?.Invoke(this); // Click �� null �� �ƴϸ� ȣ��
    }
}

class Program
{
    public static void Foo(Button source) => WriteLine("Foo");
    public static void Goo(Button source) => WriteLine("Goo");
    public static void Hoo(Button source) => WriteLine("Hoo");

    public static void Main()
    {
        Button btn1 = new Button();

        btn1.Click = Foo;
        btn1.Click += Goo;
        btn1.Click += Hoo;

        btn1.UserPressButton(); 
    }
}