using static System.Console;

// 추상 메소드가 한개 이상있는 클래스는 반드시 
// "abstract class" 라고 해야 합니다.
abstract class Shape
{
    private int color;

    public void SetColor(int c) { color = c; }
    public int GetColor() { return color; }



    // 가상 메소드 : 재정의 하지 않으면 기본 구현 제공해 줄께!!
    //              재정의 해서 바꿀수도 있어

    // 추상 메소드 : 반드시 재정의해야 한다고 지시 하는 것

    //    public virtual void Draw() { WriteLine("Draw Shape"); }
    public abstract void Draw();


    // GetArea 는 어떻게 할까 ?
    // 구현을 제공하면 : 파생 클래스는 만들지 않아도 기본 구현 제공 
    // 추상메소드 라면 : 파생 클래스는 만드시 만들어야 한다
    // 또 다른 방법 : 예외 발생

    // 1. Rect에서 override 하지 않았는데, 호출하면 예외(runtime 오류)
    // 2. Rect에서 override 하지 않았는데, 사용하지 않으면 ok.
    // 3. Rect에서 override 하고 사용하면 ok. 
    public virtual int GetArea() { throw new NotImplementedException(); }
}





class Rect : Shape
{
    public override void Draw() { WriteLine("Draw Rect"); }
}
class Circle : Shape
{
    public override void Draw() { WriteLine("Draw Circle"); }
}

class Program
{
    public static void Main()
    {
        List<Shape> list = new List<Shape>();

        while (true)
        {
            int cmd = int.Parse(Console.ReadLine() ?? "0");

            if (cmd == 1) list.Add(new Rect());
            else if (cmd == 2) list.Add(new Circle());
            else if (cmd == 9)
            {
                foreach (var s in list)
                {

                    s.Draw();


                }
            }
        }
    }
}



