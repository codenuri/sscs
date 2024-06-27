using static System.Console;

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry"); }
}

class Dog : Animal
{
    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Cat : Animal
{
    public new void Cry() { WriteLine("3. Cat Cry"); }
}


class Program
{
    public static void Main()
    {
    }
}

