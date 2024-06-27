using static System.Console;


// 해결책 #2. 모든 파생클래스(도형)의 공통된 특징은 반드시 기반 클래스에도 있어야 한다.
//           (문법적인 규칙이 아닌 디자인의 규칙)
//          그래야 Shape 참조로 해당 기능을 사용할수 있다.

class Shape
{
    public void Draw() { WriteLine("Draw Shape"); }
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

        while (true)
        {
            int cmd = int.Parse(Console.ReadLine() ?? "0");

            if (cmd == 1) list.Add(new Rect());
            else if (cmd == 2) list.Add(new Circle());
            else if (cmd == 9)
            {
                foreach (var s in list)
                {
                    
                }
            }
        }
    }
}



