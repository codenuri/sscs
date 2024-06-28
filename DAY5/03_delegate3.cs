using System;
using static System.Console;

delegate void MyFunc(int arg);

class Program
{
    public static void Foo(int arg) { WriteLine($"Foo : {arg}"); }
    public static void Goo(int arg) { WriteLine($"Goo : {arg}"); }

    public static void Main()
    {
        // #1. 메소드 여러개 등록 가능합니다.
        MyFunc f1 = Foo;
        f1 += Goo;

        f1(10); // Foo(10), Goo(10)
  
    }


}
