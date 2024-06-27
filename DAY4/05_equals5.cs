using static System.Console;

class Program 
{
	public static void Main()
	{
		string s = "ABCD";

		string s1 = "ABCD";
		string s2 = new string("ABCD");

		// s 와 s1 은 동일객체를 가리킵니다.
        WriteLine($"a == b      : {s == s1}"); // true
        WriteLine($"a.Equals(b) : {s.Equals(s1)}"); // true
        WriteLine($"object.ReferenceEquals(a, b) : {object.ReferenceEquals(s, s1)}");
                                                    // true


        // s와 s2는 다른 객체지만 상태는 동일
        WriteLine($"a == b      : {s == s2}");      // true, 다른 객체지만 == 재정의됨.
        WriteLine($"a.Equals(b) : {s.Equals(s2)}"); // true
        WriteLine($"object.ReferenceEquals(a, b) : {object.ReferenceEquals(s, s2)}");
                                                    // false 
    }
}