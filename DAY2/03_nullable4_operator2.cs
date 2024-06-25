using static System.Console;

class Car 
{
	public void Go() { WriteLine("Car Go");}
	public int  GetSpeed() { return 10; }
}

class Program
{	
	public static Car MakeCar(int speed) 
	{
		return speed < 100 ? new Car() : null;
	}

    public static void Main()
    {
        //		Car c = MakeCar(50); // ok. Car 객체가 반환됩니다.
        Car c = MakeCar(150); // null 이 반환됩니다.

//      c.Go(); // c== null 인 경우 예외 발생.

		// null 가능성이 있는 객체 사용시는 반드시 조사하고 
		// 사용하는 것이 안전합니다.
		if ( c != null) { c.Go(); }

		// 위 코드는 c != null 이면 c.Go()
		// c == null 이면 아무일도 하지 않습니다.
		// 아래 한줄이 위코드와 동일합니다.
		c?.Go();
    }      
}   

