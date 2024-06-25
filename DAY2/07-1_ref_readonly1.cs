// 07-1_ref_readonly1.cs
using static System.Console;

class Program
{
    public static void InParameter(int x)
    {
        x = 10;
    }
    public static void Main()
    {
        int n = 0;

        InParameter(n);

        WriteLine(n);    
    }
}