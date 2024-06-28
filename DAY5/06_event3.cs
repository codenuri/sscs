using static System.Console;



class Button
{
    // delegate �� class �ȿ� ���� �˴ϴ�.
    // Button �ȿ����� ����ϰڴٴ� �ǵ�
    public delegate void Handler(Button source);

    //  public Handler Click = null; // ��ư�� ������ ȣ��� �Լ����

    // ���� ���� Handler delegate �� ���� ������� ����
    // �տ� event �� ���̸� = �� �ȵǰ� +=�� �˴ϴ�.
    // => �����ϰ� ����ϱ� ���ؼ�!
    public event Handler? Click = null;

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
//      btn1.Click += Hoo;
        btn1.Click = Hoo; // += �Ѵٴ� ���� =�� �Ǽ��ߴ�

        btn1.UserPressButton(); 
    }
}