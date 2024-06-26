// property(속성) : setter 와 getter 를 쉽게 만드는 문법

class Person
{
    private int age;

    // 아래 코드가 "property" 문법의 기본 코드입니다
    public int Age
    {
        get { return age; } 
        set { age = value; }
    }
}



class Program
{
    public static void Main()
    {
        Person p1 = new Person();

        p1.SetAge(-10);

    }
}
