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


        // 핵심 #2. "Animal a = new Dog()" 일 때 a로는 Animal 고유의 
        // 멤버만 접근할수 있다.

        // 이유, a가 가리키는 객체는  실행시 변경될수 있으므로
        // if (사용자 입력값 == 1 ) a = new Cat();

        a.Age   = 10; // ok
 //     a.Color = 10; // error


        // 핵심 #3. "a" 를 사용해서 Dog 가 추가한 멤버 에 접근 하려면
        // 캐스팅해야 합니다.
        ((Dog)a).Color = 10;

        Dog d2 = (Dog)a; // 또는 이렇게
        d2.Color = 10;
        
    }
}