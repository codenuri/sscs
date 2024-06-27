using static System.Console;

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry"); }
}

class Dog : Animal
{
    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Cat : Animal
{
    public new void Cry() { WriteLine("3. Cat Cry"); }
}


class Program
{
    public static void Main()
    {
        // 73page.
        // 핵심 #1. 사용자 입력에 따라 다른 객체를 만들려면
        //          참조를 Animal 타입으로 해야 합니다.
        Animal a; 

        int n = int.Parse( Console.ReadLine() ?? "0");

        if ( n == 1 )
            a = new Dog();
        else
            a = new Cat();

        // 핵심 #2. 컴파일러는 아래 코드를 컴파일 할때
        // 1. a가 가리키는 곳에 어떤 종류(Dog, Cat) 의 객체가 있는지 알수 없습니다.
        //    => 실행시간 입력 값에 따라 결정되므로
        // 2. 컴파일러가 아는 것은 "a라는 참조 자체는 Animal 타입" 이라는 것!!
        a.Cry();
    }
}

// "a.Cry()" 를 어떤 함수와 연결할것인가 ?
// => 함수 바인딩(function binding) 이라고 합니다.

// 핵심 #3. 함수 바인딩의 종류 ( 73page)

// 1. static binding : 컴파일러가 컴파일 시간에 함수 호출을 결정
//                  컴파일러는 "a 가 가리키는 객체의 종류" 는 알수없다
//                  단지, "a 가 Animal" 이라는 것만 알수 있다.
//                  따라서, 컴파일러가 결정하면 "Animal Cry" 호출
// 논리적이지 않지만 빠른 방법
// C++/C# 언어의 기본 바인딩 정책


// 2. dynamic binding : 컴파일 시에는 "a 가 가리키는 곳을 조사하는 
//                      기계어(IL코드) 생성"
//                      실행시 메모리를 조사해서 실제 있는 객체에 따라
//                      호출 결정.
//                      a 가 가리키는 곳에 "Dog" 객체가 있다면
//                      "Dog Cry" 호출
// 논리적이지만 느린 방법.
// Java, Swift, Python 등 대부분의 객체지향 언어의 기본 바인딩 정책
// C++/C# "virtual 메소드"
