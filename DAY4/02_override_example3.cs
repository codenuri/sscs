using static System.Console;

class Shape
{
}

class Rect : Shape
{
    public void Draw() { WriteLine("Draw Rect"); }
}
class Circle : Shape
{
    public void Draw() { WriteLine("Draw Circle"); }
}

class Program
{
    public static void Main()
    {
        List<Shape> list = new List<Shape>(); 

        while(true)
        {
            int cmd = int.Parse(Console.ReadLine() ?? "0");

            if       (cmd == 1) list.Add(new Rect());
            else if ( cmd == 2) list.Add(new Circle());
            else if ( cmd == 9)
            {
                foreach( var s in list )
                    s.Draw();
            }
        }
    }
}
// 위 코드는 어디서??  왜?? 에러일까요 ?

// 해결책을 생각해 보세요.. 



