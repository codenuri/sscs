using static System.Console;

class Program
{
    static bool IsMultipleOf(int n) { return n % 3 == 0; }

    public static void Main()
    {
        int[] array = { 1, 3, 6, 4, 5 };

        // 아래 코드는 3의 배수를 찾는 코드 입니다.
        int idx1 = Array.FindIndex(array, IsMultipleOf);

        int k = 4; // 사용자가 입력한 값이라고 가정합니다.

        // 배열 x에서 k의 배수를 찾아 보세요
        // => IsMutipleOf 로 가능할까요 ?

    
    }
}
