using static System.Console;

class Program
{
    public static void Main()
    {
        int n1 = 0;
        int[] arr = { 1, 2, 3 };

        // 타입어려워 하지 마세요. 변수 선언 에서 변수 왼쪽이 타입입니다.
        // n1   : int
        // arr : int[]

        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1;
        int[] arr3 = arr1.Clone();
    }
}

