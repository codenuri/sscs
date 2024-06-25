// 58page 그림 ~ 
using static System.Console;

class Point
{
    public int x = 0;
    public int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);
}

class Program
{
    // 규칙 4. reference 타입을 "out" 로 받으면
    // 1. 기존 객체의 속성 변경 - 안됨. 초기화되지 않은 변수도 
    //                                 받을수 있으므로 객체가 없을수 있다
    // 2. 새로운 객체 담아오기 - ok.!!

    public static void OutModifier(out Point pt)
    {
//        pt.x = 2;   // error. 초기화 되지 않은 상태(객체가 없는)일수 있다
      
        pt = new Point(3, 3);   //?
    }

    public static void Main()
    {
        //      Point p1 = new Point(1, 1);
        Point p1;

        OutModifier(out p1); // out parameter 는 초기화 되지 않은
                             // 변수도 사용가능.

        WriteLine($"{p1.x} {p1.y}");
    }
}

// 일반적인 경우 
// => reference type을 인자 전달시 ref, out 으로 사용하는 경우는 많지 않습니다.
// => 단, value type 을 전달시는 ref, out 이 많이 사용될수 있습니다.
//    Swap, TryParse 등... 