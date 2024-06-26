using static System.Console;

class Car
{
    public int Color { get; set; } = 0;

    public int Count = 0;

    public Car() { ++Count; }
}

class Program
{
    public static void Main()
    {
        Car c1 = new Car();
        Car c2 = new Car();

        // Car 타입의 객체가 몇개나 생성되었는지 알고 싶다.

        WriteLine( c1.Count );
    }
}