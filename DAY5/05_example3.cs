using static System.Console;

// delegate bool Predicate<in T>(T obj); // 실제 C# 표준
delegate bool Predicate<T>(T n);

class Program
{
    public static bool IsEven(int n) => n % 2 == 0;

    public static bool Foo(double d) => d == 3.3;

    public static void Main()
    {
        int[] x = { 1, 8, 6, 4, 3 };
        int ret1 = MyFindIndex(x, IsEven);


        double[] x2 = { 1.1, 2.2, 3.3 };

        int ret2 = MyFindIndex(x2, Foo );

        WriteLine($"{ret2}"); // 2

        // Array.FindIndex() 구현 확인해 보세요
        Array.FindIndex(x2, Foo);
    }

    // 아래 코드가 실제 Array.FindInex 와 거의 동일합니다.
    public static int MyFindIndex<T>(T[] arr, Predicate<T> match)
    {
        int sz = arr.Length;

        for (int i = 0; i < sz; i++)
        {
            if (match(arr[i]))
                return i;
        }

        return -1;
    }
}