class Animal
{
    public int Age { get; set; } = 0;
}

class Dog : Animal
{
    public int Color { get; set; } = 0;
}

class Cat : Animal
{
    public int Speed { get; set; } = 0;
}

class Program
{
    public static void Main()
    {
        Dog d = new Dog();      // ok

//      string s = new Dog();   // error. 전혀 상관없는 타입의
                                // reference 로 Dog 객체를 가리킬수 없다.
        
        // 핵심 1. 기반 클래스 reference 로 파생 클래스 객체를 가리킬수 있다
        // => "upcasting" 이라고 합니다
        // => 가능한 이유는 "메모리 그림"을 생각해 보세요
        Animal a = new Dog();
    }
}