class Program
{
    // 인자로 int 만 받을수 있습니다.
    public static void M1(int n) { }

    // object 는 대부분의 타입의 기반 클래스 입니다.
    // => 모든 객체는 object 로 가리킬수 있습니다.
    // => M2 는 대부분의 타입의 객체를 한개받을수 있습니다.
    public static void M2(object n) { }

    public static void Main()
    {
        M1(10);
        M1("ABCD");

        M2(10);
        M2("ABCD");

        // 어떠한  타입을 몇개 라도 보낼수 있는메소드
        // WriteLine 의 원리
        MyWriteLine( 10, 3.4, "ABC" );
    }
    public static void MyWriteLine( params object[] arr)
    {
        foreach( object o in arr )
        {
            // 모든 타입은 object 에서 파생되는데, object 에는 ToString()이 있습니다.
            // 즉, 모든 객체는 ToString()이 있습니다.
            string s = o.ToString();

            // 이제 문자열을 출력하는 내부 함수로 s 를 출력하면 됩니다.
            Console.WriteLine( s ); // C# 내부 함수라고 가정
        }
    }
}




