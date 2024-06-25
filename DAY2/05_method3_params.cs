class Program
{
    public static void M1(int a1) { }
    public static void M2(int a1, int a2) { }
    public static void M3(int[] ar) { }

    // C# 의 가변인자 메소드
    // => M4 는 M3 과 동일하게 배열을 요구
    // => 단, M4(1,2,3) 이 가능합니다.
	public static void M4(params int[] ar) { }

    public static void Main()
    {
        // #1. M2 에는 인자를 2개만 보내야 합니다.
        M2(1, 2);    // ok
        M2(1, 2, 3); // error


        // #2. 인자의 갯수를 "가변"으로 하려면 배열로 보내면 됩니다.
        M3( new int[] { 1, 2, 3 } );  // int[] ar = new int[]{1,2,3} 이므로
        M3( new [] { 1, 2, 3 } );     // int[] ar = new []{1,2,3} 
//      M3( { 1, 2, 3 } );            // int[] ar = {1,2,3} 
                                      // 이 표기법은 에러!!

        M3( [ 1, 2, 3 ] );            // ok. C# 12 부터.. 

        // #3. 아래 처럼 사용할수 있을까요 ?
        M3(1, 2, 3); // error. M3 는 "배열"을 요구 합니다.

        // #4. 가변 인자 메소드 사용
        M4(new int[] { 1, 2, 3 });
        M4(1, 2, 3); // ok!! 핵심
                     // 1,2,3 을 컴파일러가 "new int[]{1,2,3}" 으로변경
    }







    // 주의 사항
//  public static void M5(int[] ar, int n) { }			
//	public static void M6(params int[] ar, int n) { }	

}
	