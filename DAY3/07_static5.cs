// 아래 코드를 보고 에러를 모두 찾으세요
// 핵심 
// static method : 객체가 없어도 호출가능
// static field  : 모든 객체가 공유, 객체가 없어도 메모리에 존재 
/*
class Example
{
    public int data1 = 0;
    public static int data2 = 0;

    public void M1()
    {
        // M1 이 호출되었다는 것은 "객체가 있다" 는 의미. 
        data1 = 0;  // 1    // ok 객체가 있으므로 data1도 있다
        data2 = 0;  // 2    // ok
        M2();       // 3    // ok
    }
    public static void M2()
    {
        data1 = 0;  // 4. error
        data2 = 0;  // 5. ok
        M1();       // 6. error

        M3(); // ok. 
    }
    public static void M3() {}
}
*/
class Program
{
    public static void Main()
    {
        Example.M2();   // static 메소드 이므로 객체 없어도 언제라도
                        // 호출가능
    }
}