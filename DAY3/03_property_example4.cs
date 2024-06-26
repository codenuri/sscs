class Person
{
    private string name;
    private int age;

    // Name, Age 속성 제공해 보세요

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