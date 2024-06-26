
// auto implemented property vs public 필드

class Person
{
    // 아래 코드는 필드가 아닌 속성입니다.
    // => get, set 중 한개만 제공할수도 있습니다.
    public string Name { get; }
    public string Address { get; set; }

    public Person(string name, string address)
    {
        Name = name;        // Name 은 get-only 입니다.
                            // auto property는 
                            // 생성자에서는 접근 가능
                            // auto 가 아닌 경우는 필드이름 사용하면됩니다.
                            // auto 는 필드이름을 알수 없으므로!
                            // 초기화는 허용하기 위해
                           

        Address = address;
    }
}

class Program
{
    public static void Main()
    { 
        Person p = new Person("kim", "seoul");

 //       p.Name = "kim";      // error. set 안됨
        string s = p.Name;   // ok.. get 은 가능

        p.Address = "seoul"; // R/W 가능
    }
}