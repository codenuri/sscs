using static System.Console;

// C# 의 대부분의 타입은 object(Object) 로 부터 상속됩니다.
// => "명시적으로 표기하지 않아도 자동으로!!"
/*
class Object
{
    // 이 안에는
    // 4개의 non-virtual method 와
    // 3개의 virtual method 가 있습니다.

    public virtual string? ToString()
    {
        // 기본 구현은 "자신의 타입(클래스이름)" 을 
        // 문자열로 만들어서 반환 합니다.
    }
}
*/


class Point   // : Object
{
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;

    public Point(int a, int b) => (X, Y) = (a, b);

    public override string ToString()
    {
        // X, Y 의 값을 문자열로 만들어서 반환
        // => $ 문자열은 WriteLine 에서만 사용할수 있는 것이 아니라
        //   일반적으로 사용가능합니다.

        return $"{X}, {Y}";
    }
}

class Program
{
    public static void Main()
    {
        Point p = new Point(1, 2);

        string s =  p.ToString();

        WriteLine(s);
    }
}



