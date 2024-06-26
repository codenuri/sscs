// 07_static6.cs
class Example
{
    public static void M1() { }
    public void M2() { }
}

class Program
{
    public static void Main()
    {
        // #1. static method 는 객체없이 클래스 이름으로 호출
        Example.M1();

        // #2. instance method 는 반드시 객체 필요
        Example e = new Example();
        e.M2(); // 반드시 객체 e가 있어야 합니다.
    }
}
