class Animal       { public int Age { get; set; } = 0; }

class Dog : Animal { public int Color { get; set; } = 0;}
class Cat : Animal { public int Speed { get; set; } = 0;}

class Program
{
    // Upcasting 의 활용(장점) #1
    // => 동종을 처리하는 메소드를 만들수 있다.
    // => 모든 동물을 인자로 받을수 있는 메소드

    // 모든 동물은 1년이 지나면 1살 증가합니다.
//  public static void NewYear(Dog obj) // Dog 만 전달 받을수 있다.
    public static void NewYear(Animal obj)  // 모든 동물을 받을수 있다
    {
        ++(obj.Age);
    }

    // 참고
//  public static void NewYear(object obj) { }



    public static void Main()
    {
        Dog d = new Dog();
        Cat c = new Cat();

        NewYear(d);
        NewYear(c);

        // Upcasting 활용(장점) #2. 동종을 보관하는 배열(컬렉션)만들기
        Dog[] arr1 = new Dog[10];        // Dog의 객체의 참조만 보관 가능
        Animal[] arr2 = new Animal[10]; // 모든 동물의 참조를 보관가능

        arr2[0] = new Dog();
        arr2[1] = new Cat();

    }


}