// auto-implemented property
class Example
{
    // 필드 한개와 연결된 Property를 만드는 전형적인 코드는 아래와 같습니다
    private int data1 = 0;

    public int Data1 
    { 
        get { return data1; } 
        set { data1 = value; } 
    }

    // 위 코드에서 set, get 은 
    // 어떠한 추가적인 로직없이 단지 "필드"를 직접 R/W 하고 있습니다.

    // 아래 한줄이 위 코드와 완전히 동일합니다.
    // => 필드 추가되고(이름은 알수 없음), setter, getter 추가
    // => "auto implemented property" 라고 합니다.
    public int Data2 { set; get; } = 0;

}



class Program
{
    public static void Main()
    {

    }
}
