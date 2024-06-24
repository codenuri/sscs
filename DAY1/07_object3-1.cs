// C# 은 함수 오버로딩 문법을 지원합니다
// => 인자의 타입이나 갯수가 다르면 동일 이름의 함수를
//    여러개 만들수 있다는 것

int    Square(int a)    { return a * a; }
double Square(double a) { return a * a; }


int n = Square(3);


// 컴파일러가 위코드를 아래 코드로 변경한것
// => Square 함수(메소드)는 Main 메소드 안에서 만들어진 함수 입니다
// => "메소드" 안에서 다시 함수(메소드)를 만드는 것을
//    "nested function" 이라고 합니다.
// => "nested function" 은 오버로딩 될수 없다는 문법이 있습니다.   
class Program
{
    public static void Main()
    {
        int Square(int a) { return a * a; }
        double Square(double a) { return a * a; }


        int n = Square(3);
    }
}
