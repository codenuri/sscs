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

// a.Cry() 를 어떤 함수와 연결할것인가 ?
// => 함수 바인딩(function binding) 이라고 합니다.

// 핵심 #3. 함수 바인딩의 종류 ( 73page)

// 1. static binding : 


// 2. dynamic binding : 

