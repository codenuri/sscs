using static System.Console;

/*
// 객체가 자신과 동일하게 생긴 복사본을 만드는 작업은
// 자주 사용되는 작업입니다.
// 메소드 이름을 인터페이스로 약속합니다.
interface ICloneable
{
    Object Clone();
}

// 배열은 복제개념을 제공합니다.
class Int32[] : ICloneable 
{
    public Object Clone()
    {
        // 자신과 동일한 요소를 가지는 배열을 한개 더생성해서
        //  반환합니다.
    }
}
*/


class Program
{
    public static void Main()
    {
        int n1 = 0;
        int[] arr = { 1, 2, 3 };

        // 타입 어려워 하지 마세요. 변수 선언 에서 변수 왼쪽이 타입입니다.
        // n1  : int
        // arr : int[]


        int[] arr1 = { 1, 2, 3 };

        int[] arr2 = arr1; // arr2 는 arr1 과 같은 배열 공유

//      int[] arr3 = arr1.Clone(); // arr1 과 동일한 배열을 한개 더생성해서
                                            // arr3가 가리키겠다는 의도

        // 위 코드는 왜 에러 일까요 ?
        // 해결책은 ?
        int[] arr3 = (int[])arr1.Clone();
    }
}

