// 51 page ~
class Program
{
    public static void SetRect(int x, int y, int width, int height) 
    {
    }

    public static void Main()
    {
        // 메소드를 호출하는 코드만 보고 인자의 의미를 예측해 보세요
        // 1. x, y, width, height 라고 생각할수도 있고
        // 2. x1, y1, x2, y2 라고 생각할수도 있습니다.
        SetRect(10, 10, 30, 30);

        // 아래처럼 호출하면 어떨까요 ?
        SetRect(x:10, y:10, width:30, height:30);

        // #1. 용어
        SetRect(10, 10, 30, 30); // Positional Argument
        SetRect(x: 10, y: 10, width: 30, height: 30); // Named Argument
                                                      // C#, Objective-C, swift 등에서 사용
                                                      // java, C++, Python 에 없는 문법

        // #2. Named Argument 는 인자 순서 변경 가능합니다.
        SetRect(width: 10, y: 10, height: 30, x: 30);

        // #3. Positional 과 Named 를 섞어서 사용해도 됩니다.
        SetRect(10, 10, width:30, height:30);
        SetRect(x:10, y:10, 30, 30);

        // #4. 주의 사항
        // Named Argument 의 순서가 변경된 경우
        // 이후 부터는 Positional 은 사용할수 없습니다.
        SetRect(y: 10, x: 10, 30, 30); // error

        SetRect(x: 10, 10, Width:30, 30); // ok. 순서 변경 안됨.


    }
}
