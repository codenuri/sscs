class Person
{
    private string name;
    private int age;

    public Person(string n, int a) => (name, age) = (n, a);
}

// Person 으로 부터 상속받는 Student 만들어 보세요 
// 1. int id 추가해 보세요
// 2. Student 생성자 만들어 보세요
// 3. Main 에서 Student 객체 생성해 보세요
// => 복습하실떼 아래 코드를 다른 언어(C++, java, python) 로도 만들어 보세요!!

class Student : Person
{
    private int id;

    /*
    // 사용자 코드           // 컴파일러가 변경한 코드
    public Student(int n)   // public Student(int n) : base()
    {
        id = n;
    }
    */
    // 기반 클래스에 디폴트 생성자가 없으므로 반드시 개발자
    // 명시적으로 호출해야 합니다.
    public Student(string name, int age, int n)  : base(name, age)
    {
        id = n;
    }
}

class Program
{
    public static void Main()
    {
        Student s = new Student("kim", 34, 15);
    }
}