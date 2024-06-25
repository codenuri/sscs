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
    }
}
