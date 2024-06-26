using static System.Console;


class Car
{
    public int Color { get; set; } = 0;

    public Car() { ++Count; }


    private static int Count = 0;

    public int GetCount() => Count;    
}

class Program
{
    public static void Main()
    {
        Car c1 = new Car();
        Car c2 = new Car();

//      Car.Count = -10; // error. private 필드

        WriteLine(c1.GetCount());
    }
}

