class Program
{
    // Generic Method
    public static void swap<T>(ref T a, ref T b)
    {
        T tmp = a;
        a = b;
        b = tmp;
    }

    public static void Main()
    {
        int n1 = 10, n2 = 20;
        double d1 = 1.1, d2 = 2.3;

        swap<int>(ref n1, ref n2);      // 이순간 "메소드틀"에서 T=int인
                                        // swap(ref int, ref int) 메소드생성
        swap<double>(ref d1, ref d2);   // swap(ref double, ref double) 메소드생성

        // generic 메소드는 함수 인자로 타입 추론이 가능합니다.
        // "swap<int>" 같이 타입을 전달해도 되고, 생략해도 됩니다
        swap(ref n1, ref n2);

        M1(1, 2);   // ok
        M1(1, 1.2); // ok. double 로 추론. 
        M1("aaa", 1.2); // error

        M2(1, 1.2); // ok 
        M3(1, 1.2); // ok
//      M4(1);      // error. 인자 타입은 인자로 추론되지만
                    // 반환 타입은 추론 될수 없습니다.
        M4<int, int>(1); // ok

    }

    public static void M1<T>(T a, T b) { }
    public static void M2<T1, T2>(T1 a, T2 b) { }
    public static void M3<A, B>(A a, B b) { } // 아무문자나 사용가능
    public static R    M4<R, T>(T a) { return default(R); }      // 반환 타입
}