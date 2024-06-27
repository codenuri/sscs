using static System.Console;

class Program 
{
	public static void Main()
	{
		string s = "ABCD";

		string s1 = "ABCD";
		string s2 = new string("ABCD");

		// s �� s1 �� ���ϰ�ü�� ����ŵ�ϴ�.
        WriteLine($"a == b      : {s == s1}"); // true
        WriteLine($"a.Equals(b) : {s.Equals(s1)}"); // true
        WriteLine($"object.ReferenceEquals(a, b) : {object.ReferenceEquals(s, s1)}");
                                                    // true


        // s�� s2�� �ٸ� ��ü���� ���´� ����
        WriteLine($"a == b      : {s == s2}");      // true, �ٸ� ��ü���� == �����ǵ�.
        WriteLine($"a.Equals(b) : {s.Equals(s2)}"); // true
        WriteLine($"object.ReferenceEquals(a, b) : {object.ReferenceEquals(s, s2)}");
                                                    // false 
    }
}