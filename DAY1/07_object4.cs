using static System.Console;

// ��κ��� Ÿ���� "object(System.Object)" �� ���� �Ļ�(���)�ȴ�.
// => "readonly struct" ��� Ÿ�Ը� object ���� �Ļ����� �ʽ��ϴ�.

// => System.Object �� 7���� �޼ҵ带 �����մϴ�.
// => 4���� instance method(��ü�� �����ϰ� ���� ȣ���ϴ� �޼ҵ�)
// => 3���� static method  (class �̸����� ȣ���ϴ� �޼ҵ�)
// => 104 page ����
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
