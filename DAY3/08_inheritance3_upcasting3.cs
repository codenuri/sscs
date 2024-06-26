class Animal       { public int Age { get; set; } = 0; }

class Dog : Animal { public int Color { get; set; } = 0;}
class Cat : Animal { public int Speed { get; set; } = 0;}

class Program
{
    // 모든 동물은 1년이 지나면 1살 증가합니다.
    public static void NewYear(Dog obj)
    {
        ++(obj.Age);
    }

    public static void Main()
    {
        Dog d = new Dog();
        Cat c = new Cat();

        NewYear(d);
        NewYear(c);

        Dog[] arr = new Dog[10];

    }


}