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
        // 추가 : +=
        // 제거 : -=
        MyFunc f1 = Foo;
        f1 += Goo;

//      f1(10); // Foo(10), Goo(10)


        // #2. delegate 는 "reference type",
        // "immutable" 합니다.

        MyFunc f2 = Foo; // new MyFunc(Foo)
        MyFunc f3 = f2;

        WriteLine($"{object.ReferenceEquals(f2, f3)}");

//        f2 += Goo; // new MyFunc(f2, Goo) 의미의 코드
                    // 직접 이렇게는 안되고 += 로해야 합니다.
                    // 아래 처럼 하면 됩니다.
        f2 = (MyFunc)Delegate.Combine(f2, new MyFunc(Goo));


        WriteLine($"{object.ReferenceEquals(f2, f3)}");

        f3 = f2;

        WriteLine($"{object.ReferenceEquals(f2, f3)}");
        f3(10); // 결과 예측해 보세요.
                // 1. Foo, Goo
                // 2. Foo   <= 정답!

        f2 -= Foo; // new MyFunc

        WriteLine($"{object.ReferenceEquals(f2, f3)}");
        WriteLine("---");
        f3(10);
    }


}
