using static System.Console;

delegate void Handler(Button source);

class Button
{
    public Handler Click = null; // 버튼을 누를때 호출될 함수등록

    public void UserPressButton()
    {
        Click?.Invoke(this); // Click 이 null 이 아니면 호출
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