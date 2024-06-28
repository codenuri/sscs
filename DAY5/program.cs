// CMC.cs  와 program.cs 만 빌드 풀러놓으세요

class Program
{
    public static void Main()
    {
        string s = "aa";
        int n = 10;

        Console.WriteLine($"{CMC.SizeOf<int>()}");

        CMC.PrintHeapObjectAddr(s);

        unsafe
        {
            CMC.PrintAddr(&n);
        }

    }
}