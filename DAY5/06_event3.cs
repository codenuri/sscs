using static System.Console;



class Button
{
    // delegate 를 class 안에 만들어도 됩니다.
    // Button 안에서만 사용하겠다는 의도
    public delegate void Handler(Button source);

    //  public Handler Click = null; // 버튼을 누를때 호출될 함수등록

    // 위와 같이 Handler delegate 를 직접 사용하지 말고
    // 앞에 event 를 붙이면 = 은 안되고 +=만 됩니다.
    // => 안전하게 사용하기 위해서!
    public event Handler? Click = null;

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
//      btn1.Click += Hoo;
        btn1.Click = Hoo; // += 한다는 것을 =로 실수했다

        btn1.UserPressButton(); 
    }
}