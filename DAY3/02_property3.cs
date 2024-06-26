class Person
{
    private int age;

    // 아래 코드를 보고 컴파일러가
    // => set_Age(int value), get_Age() 메소드를 생성
    public int Age
    {
        get { return age; }
        set { age = value; }    
    }

    // 아래 메소드 추가하고 빌드해보세요
    // => 에러 입니다.
    // => Property 를 사용하면 이미 아래 함수가 생성되므로
    //    이름 충돌
    // => Property 가 없으면 만들수 있습니다.
    public void set_Age(int a)
    {

    }
}

class Program
{
    public static void Main()
    {
        Person p1 = new Person();

        // Property 의 원리
        p1.Age = 10;     // 컴파일러가 p1.set_Age(10) 으로 변경   

        int n = p1.Age;  // p1.get_Age() 로 변경   
                            

        Console.WriteLine(n);

    }
}

// 1. 위코드 빌드해 놓으세요
// 2. ildasm 실행하세요
//    (윈도우시작버튼 => visual studio 폴더 => "Developer command prompt 실행" 후
//     나타나는 창에서 "ildasm.exe" 으로 실행

// 3. ildasm 에서  "DAY3.dll" 열어 보세요
//    => DAY3/bin/debug/net8.0/day3.dll 
