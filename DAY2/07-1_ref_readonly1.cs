// 07-1_ref_readonly1.cs
using static System.Console;

// #1. value type 을 "ref, out" 없이 전달하면
// => 원본인자를 수정할수 없습니다.
// => "안전합니다."

// #2. 그런데, "크기가 큰 value type" 이라면 복사본에 대한 오버헤드
//     가 있습니다.
// #3. ref 로 전달하면 "복사본"에 대한 메모리 오버헤드를 제거할수 있습니다.
// => 이 경우, 함수안에서 "원본 인자"를 수정할수있게 됩니다.
// => 안전성이 떨어 집니다.
// => C++ 은 이럴때 "const reference" 를 사용합니다.
// => C# 7.0 에 이 개념이 추가되었습니다.

// C#1.0 : ref, out 도입
// C#7.0 : in 도입 - C++의 const reference 

// #4. in parameter 를 사용하면 "읽기전용 reference" 로 전달 할수 있습니다.

class Program
{
    public static void RefParameter(ref int x)
    {
        x = 10; // x는 reference!!
                // 가리키는 곳을 R/W 가능
    }
    public static void InParameter(in int x)
    {
        // x 는 reference, 가리키는 곳을 읽기만 가능
//      x = 10;    // error
        int n = x; // ok
    }

    public static void Main()
    {
        int n = 0;

        RefParameter(ref n); // ok
        RefParameter(n);     // error. ref 인자는 반드시 ref 붙여야 합니다.
                             // 호출자 입장에서 "바뀐다는 것은 명확히 알아야합니다."

        InParameter(in n);  // ok
        InParameter(n);     // ok. in 생략 가능. 변하지 않으므로 
                            //                   in 적지 않아도 위험하지 않습니다.
        WriteLine(n);    
    }
}