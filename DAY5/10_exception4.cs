class Program
{
    public static void Main()
    {
        string s = "A";

        try
        {
            int n = int.Parse(s);
        }
        catch(FormatException e)  
        {
            Console.WriteLine(e.Message); // 설명
            Console.WriteLine(e.Source); // 
            Console.WriteLine(e.StackTrace); // call stack
        }
    }
}