class Person
{
    private string name;
    private int age;

    // 생성자 규칙 정리
    // #1. 객체를 생성하면 반드시 생성자가 호출됩니다.
    // #2. 사용자가 생성자를 한개도 만들지 않으면 컴파일러가 한개 제공한다.
    //     => 디폴트 생성자(인자가 없는 생성자) 라고 합니다

    // #3. 사용자가 생성자를 어떤 형태든(인자가 있건 없건) 만들면
    //     => 컴파일러는 디폴트 생성자를 제공하지 않는다

    //  public Person() { }

    public Person(string n, int a) => (name, age) = (n, a);
}
class Program
{
    public static void Main()
    {
//      Person p = new Person(); // error. 인자가 없는 생성자가 없습니다.
        Person p = new Person("kim", 20); // ok
    }
}