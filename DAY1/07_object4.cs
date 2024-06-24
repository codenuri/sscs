using static System.Console;

// 대부분의 타입은 "object(System.Object)" 로 부터 파생(상속)된다.
// => "readonly struct" 라는 타입만 object 에서 파생되지 않습니다.

// => System.Object 는 7개의 메소드를 제공합니다.
// => 4개의 instance method(객체를 생성하고 나서 호출하는 메소드)
// => 3개의 static method  (class 이름으로 호출하는 메소드)
// => 104 page 참고
class Car  // class Car : System.Object
{	
}

class Program
{
	public static void Main()
	{
		Car c = new Car();
		WriteLine( c.ToString() ); // "Car" 

		object o;

	}
}
