using static System.Console;

class Program
{
    public static bool IsEven(int n) => n % 2 == 0;

    public static void Main()
    {
        int[] x = { 1, 8, 6, 4, 3 };

        int ret1 = Array.FindIndex(x, IsEven);
        int ret2 = MyFindIndex(x, IsEven);
    }
    // Array.FindIndex 를 직접 만들어 봅시다.

}