using static System.Console;

class Program
{
    public static void ValueParameter(int x) { }
    public static void RefParameter(ref int x) { }
    public static void InParameter(in int x)  {  }
    public static void RefReadonlyParameter(ref readonly int x){}

    public static void Main()
    {
        int n = 0;

        ValueParameter(n);
        RefParameter(ref n);        // ok
        InParameter(in n);          // ok. in 생략 가능
        RefReadonlyParameter(ref n);// ok

        ValueParameter(3); // 변수 대신 literal 전달
                           // 변수는 lvalue(메모리가 있고, 이름이 있다)
                           // literal ( 메모리가 할당된게 아니라, 값만)

        RefParameter(ref 3); // error. rvalue 인 3을 ref로 전달할수 없다.
                             // 3은 메모리가 없다!! 주소를 구할수 없다.
                             // ref로 보내는 것은 "담아오겠다는 의도"도 있다
                             // 메모리가 없으므로 담을수 없다.

        InParameter(3); // ok.. 이순간
                        // 임시로 메모리가 한개 할당되고 3으로 초기화 됩니다
                        // 그리고, 임시메모리의 주소가 함수에 전달됩니다.
                        // "in" 파라미터는 임시객체가 생성될수 있다!!
                        // 라는 특징이 있습니다.

        RefReadonlyParameter(ref 3); // error.
                        // ref readonly 는 lvalue 만 전달 가능합니다.
                        // 임시객체 생성에 따른 성능저하는 막기 위해서..!!

    }
}

