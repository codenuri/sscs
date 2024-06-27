// object1.cs
using System.Drawing;

class Program
{
    public static void Main()
    {
        // 이미 C# 언어에 "Rectangle", "Point" 가 있습니다.
        // => using System.Drawing; 가 필요

        Rectangle r = new Rectangle(1, 1, 1, 1);

        Point p = new Point(1, 1);


        // 개발을 하다 보면 변수값(객체의 속성)을 화면 출력하고
        // 싶을때가 있습니다.
        // => C#, Java 에서는 이럴때 모든 객체가 가진 ToString() 을 호출하면됩니다
        // => Java : toString()

        Console.WriteLine( r.ToString() );
        Console.WriteLine( p.ToString() );
    }
}