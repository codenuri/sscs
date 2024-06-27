using static System.Console;


interface ICamera
{
//  private int color;  // error. 필드를 가질수 없습니다.

//  public void SetColor(int c) => color = c; // error. 메소드 제공안됨

    void Take();  // ok

    int Weight { get; }; // ok. Weight 속성을 반드시 만들라는 의미
}

class Camera : ICamera
{
    public void Take() { }
}



class Program
{
    public static void Main()
    {
 

    }
}

