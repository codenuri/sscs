using static System.Console;

class Test
{
    public static void SMethod(int arg) 	
		=> WriteLine("Test.SMethod");

    public void IMethod(int arg)
		=> WriteLine("Test_Object.IMethod");
}

delegate void MyFunc(int arg);

class Program
{
    public static void Main()
    {
        // 아래 주석을 항상 생각하세요
        // static method   : 클래스 이름으로 호출. 객체 없어도 됩니다.
        // instance method : 객체이름을 호출. 반드시 객체가 생성되어야 호출가능

        // 핵심 : delegate 에 method 를 등록하는 방법

        MyFunc f1 = Test.SMethod;  // static method 는 "클래스이름.메소드이름"
        
//      MyFunc f2 = Test.IMethod; // error.

        Test t = new Test();    
        MyFunc f2 = t.IMethod;  // ok. instance method는
                                // "객체이름.메소드이름"

    }
}
