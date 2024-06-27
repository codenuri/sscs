// Generic 클래스
// => 클래스가 아닌 "클래스를 생성하는 틀"
// => "Point<int>" 로 사용하면 T=int 인 클래스를 컴파일러가 생성
class Point<T>
{
    public string  name1 = null; // C# 9.0 부터 경고. 
    public string? name2 = null; // ok. null 가능 참조 타입
    public string  name3 = null!; // ok. null 가능 참조 아니지만 최초 초기화면 null 사용
    

    public T X { get; set; } = default(T)!;
    public T Y { get; set; } = default!;
}

class Program
{
    public static void Main()
    {
        Point<int> p = new Point<int>();
        p.X = 1;
        p.X = 2;
        Point<double> p1 = new Point<double>();

    }
}

