using static System.Console;

// instance xxxx : 객체의 데이타와 관련 있는 것.. 
// static   xxxx : 객체 자체의 데이타와는 관련 없는것

// static field  : 모든 객체가 공유하는 데이타
// static method : 객체 없이 호출가능한 메소드


class Car
{
    public int Color { get; set; } = 0;

    public Car() { ++Count; }


    private static int Count = 0;

    //  public int GetCount() => Count;     // instance method
                                            // 객체가 있어야만 호출가능하다

    public static int GetCount() => Count;  // static method
                                            // 객체가 없어도 호출가능 하다.
                                            // "클래스이름.메소드이름" 으로 호출
}

class Program
{
    public static void Main()
    {
        // 이 위치에서 자동차 객체의 갯수를 알고 싶다!
        WriteLine(Car.GetCount());

        Car c1 = new Car();
        Car c2 = new Car();

//      Car.Count = -10; // error. private 필드

        WriteLine(Car.GetCount());
    }
}

