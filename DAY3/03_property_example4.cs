using static System.Console;

// C#은 별도의 용어가 없지만
// Swift 에서는
// Name, Age   : 필드가 있는 속성이므로 "Stored Property"
// Description : "Calculation Property" 라고 합니다

class Person
{
    private string name;
    private int age;

    // Name, Age 속성 제공해 보세요
    public string Name
    { 
        get => name;
        set => name = value;
    }
    public int Age 
    {
        get => age;
        set => age = value;
    }

    // Description 속성도 만드세요
    public string Description
    {
        get => name + " " + age.ToString();
    }

    public Person(string n, int a)
    {
        Name = n;
        Age = a;
    }
}
class Program
{
    public static void Main()
    {
        Person p = new Person("kim", 20);
        WriteLine(p.Description); // "kim 20" 나오게해보세요
    }
}