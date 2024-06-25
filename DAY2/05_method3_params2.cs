class Program
{
    // 인자로 int 만 받을수 있습니다.
    public static void M1(int n) { }

    // object 는 대부분의 타입의 기반 클래스 입니다.
    // => 모든 객체는 object 로 가리킬수 있습니다.
    public static void M2(object n) { }

    public static void Main()
    {
        M1(10);
        M1("ABCD");

        M2(10);
        M2("ABCD");
    }
}