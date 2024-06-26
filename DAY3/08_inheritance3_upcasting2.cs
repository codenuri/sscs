class Animal
{
    public int Age { get; set; } = 0;
}

class Dog : Animal
{
    public int Color { get; set; } = 0;
}

class Program
{
    public static void Main()
    {
        Animal a = new Dog();

        // 실행시간 입력결과에 따라 a가 가리키는 객체는 변경됩니다.
        int n = int.Parse( Console.ReadLine() );

        if ( n == 1 )
        {
            a = new Animal();
        }
        //---------------------------------------------



        a.Color = 0;
    }
}