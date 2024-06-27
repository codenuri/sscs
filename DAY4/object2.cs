using System.Reflection;

class Program
{
    public static void Main()
    {
        string s = "hello";

        object obj = s;

        // obj 가 가리키는 객체의 타입을 알고 싶다.!!
        // 방법 #1. is 연산자

        bool b = obj is string; // if ( obj is string )


        // 방법 #2. reflection 
        // => object 클래스가 제공하는 7개 메소드 중에 "GetType()" 사용

        Type t = obj.GetType(); // obj 가 "가리키는 타입"에 대한 정보를 담은
                                // Type 객체 반환

        //      Console.WriteLine( t.Name);
        //      Console.WriteLine( t.BaseType?.Name);

        Console.WriteLine( t.FullName);
        Console.WriteLine( t.BaseType?.FullName);

        // C# 의 reflection(타입정보를 얻는기술)은 아주 뛰어납니다.
        var methods = t.GetMethods(); // 모든 메소드의 정보를 배열로 얻기
        // MethodInfo[] methods 

        foreach (MethodInfo mi in methods)
        {
            Console.WriteLine($"{mi.Name}, {mi.ReturnType}");

            // 파라미터도 알고 싶으면
            //var parameters = mi.GetParameters();
        }

        var fields = t.GetFields(); // public 필드만. 

        foreach (FieldInfo fi in fields)
        {
            Console.WriteLine($"{fi.Name}");
        }


        // 타입정보를 알고 싶으면 "Type" 타입의 객체가 필요 합니다.

        string s1 = "ABC";

        Type t1 = s1.GetType();     // 1. 객체가 가진 GetType() 메소드 호출
        Type t2 = typeof(string);   //2. 클래스 이름으로 Type 정보 얻기
                                    // typeof 키워드(연산자) 사용
    }
}

// 결국 object 제공 7 개중에
// ToString() 같은 가상 메소드가 3개
// GetType() 같은 non-virtual 이 4개 




