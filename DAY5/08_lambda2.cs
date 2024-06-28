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
        // => FindIndex의 2번째 인자는 반드시 인자가 한개이어야 합니다.
        // => IsMutipleOf 가 인자 한개를 유지하면서 main 의 지역변수인 k를
        //   사용할수 없습니다.
        // 즉, 일반 메소드는 Main 의 지역변수 접근 안됩니다.

        //------------------------
        // 람다는 됩니다.

        // => 람다표현식 안에서는 자신이 포함된 함수의 지역변수를
        //    접근할수 있습니다.
        int idx2 = Array.FindIndex(array, n => n % k == 0 );
    }
}
