using static System.Console;


interface ICamera
{
//  private int color;  // error. 필드를 가질수 없습니다.

//  public void SetColor(int c) => color = c; // error. 메소드 제공안됨

    void Take();  // ok

    int Weight { get; }; // ?
}



class Program
{
    public static void Main()
    {
 

    }
}

