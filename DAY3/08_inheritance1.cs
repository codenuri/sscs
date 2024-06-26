// #1. 상속을 사용하지 않는 경우
// => name, age 가 중복된다.
/*
class Student
{
    private string name;
    private int age;
    private int id;
}
class Professor
{
    private string name;
    private int age;
    private int major;
}
*/
// #2. 상속을 사용하는 코드

// 모든 사람의 공통을 특징을 먼저 설계하고
class Person
{
    private string name;
    private int age;
}
class Student : Person
{
    private int id;
}
class Professor : Person
{
    private int major;
}

class Program
{
    public static void Main()
    {
        Student s = new Student(); // name, age, id 를 가진 객체 생성
    }
}

