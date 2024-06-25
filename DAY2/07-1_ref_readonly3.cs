using static System.Console;

class Program
{
    public static void ValueParameter(int x) { }
    public static void RefParameter(ref int x) { }
    public static void InParameter(in int x)  {  }
    public static void RefReadonlyParameter(ref readonly int x){}

    public static void Main()
    {
        int n = 0;

        ValueParameter(n);
        RefParameter(ref n);        // ok
        InParameter(in n);          // ok. in 생략 가능
        RefReadonlyParameter(ref n);// ok

    }
}

