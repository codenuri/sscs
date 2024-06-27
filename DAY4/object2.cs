class Program
{
    public static void Main()
    {
        string s = "hello";

        object obj = s;

        // obj 가 가리키는 객체의 타입을 알고 싶다.!!
        // 방법 #1. is 연산자

        bool b = obj is string; // if ( obj is string )


        // 방법 #2. reflection 
        // => object 클래스가 제공하는 7개 메소드 중에 "GetType()" 사용

        Type t = obj.GetType(); // obj 가 가리키는 타입에 대한 정보를 담은
                                // Type 객체 반환

        Console.WriteLine( t.Name);
        Console.WriteLine( t.BaseType?.Name);
    }
}