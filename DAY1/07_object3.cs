// top level programming 의 원리
System.Console.WriteLine("Hello, C#");



// 컴파일러가 위코드를 아래처럼 변경합니다.
// => 임의이름을 가진 클래스를 만들고
// => Main 메소드를 만든후에
// => 위 코드를 Main 메소드 안으로 옮겨 놓게 됩니다.
class Program
{
    public static void Main()
    {
        System.Console.WriteLine("Hello, C#");
    }
}