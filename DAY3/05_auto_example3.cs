
// auto implemented property vs public 필드

class Person
{
    //    public string Name { get; }   // setter 없음. 
                                        // 단, 생성자에서는 set 가능

    public string Name { get; private set; } // setter 있지만 private
                                        // 자신의 모든 메소드 에서는 사용가능
                                        // 외부에서는 접근 안됨.


    public string Address { get; set; }

    public Person(string name, string address)
    {
        Name = name;        
        Address = address;
    }
}

class Program
{
    public static void Main()
    {
        Person p = new Person("kim", "seoul");

        string s = p.Name;   

        p.Address = "seoul";
    }
}

// 추가적으로
// 속성으로 만들면
// "객체가 가진 모든 속성을 자동으로 열거해서 출력해 주는 라이브러리들이 있습니다.
// "Name, Address" 를 필드로 만들면 이런 기능을 사용할수 없습니다.

// DataGrid g = new DataGrid();
// g.Add(p); // p가 가진 속성을 모든 값을 자동으로 보여주는 기능