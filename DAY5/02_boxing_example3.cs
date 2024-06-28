using static System.Console;


// C# 1.0 : Generic 문법이 없었습니다.
interface IComparable
{
    int CompareTo(object obj);
}

// C# 2.0 : Generic 문법이 도입되었습니다
interface IComparable<T>
{
    int CompareTo(T obj);
}


// 결론 : 사용자 클래스에 CompareTo 같은 메소드를 만들려면
// 1. 인터페이스를 먼저 표시하고 만드세요
// 2. IComparable 인터페이스를 구현하면 인자가 object 이어야 합니다.
// 3. IComparable<T> 버전을 사용하면 정확한 타입으로 할수 있으므로
//    Boxing 등의 오버헤드가 없어집니다.

// 권장 : IComparable<Digit>, IComparable 를 모두 구현!!
// 즉, CompareTo 를 2개 만들라는 의미..

struct Digit : IComparable<Digit>, IComparable
{
    public int Value { get; set; }

    public Digit(int n) => Value = n;

 
    public int CompareTo(Digit other)
    {
        return Value.CompareTo(other.Value);
    }

    public int CompareTo(object other)
    {
        Digit obj = (Digit)other;

        return Value.CompareTo(obj.Value);
    }
}

class Program
{
    public static void Main()
    {
        Digit d1 = new Digit(3);
        Digit d2 = new Digit(4);

        int ret = d1.CompareTo(d2); // object 가 아닌 Digit 버전 호출
                                    // Boxing 없음, 오버헤드 없음

        Foo(d1); // ok.  "IComparable" 인터페이스도 호환됨
    }

    public static void Foo(IComparable ic)
    {

    }
}


