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

        // a 가 가리키는 객체는 실행시 사용자 입력에 따라
        // Color 가 있을수도 있고 없을수도 있습니다.

        // static type check : Color가 없을수도 있으니 컴파일시간 에러발생하자
        // dynamic type check : 컴파일은 허용하고, 실행시 Color가 없으면
        //                      실행시 에러(예외 발생)내자.

        a.Color = 0;
    }
}