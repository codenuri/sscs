using static System.Console;

class Program
{
    static bool IsEven(int n) { return n % 2 == 0; }

	public static void Main()
    {
        int[] array = { 1, 3, 6, 4, 5 };

		int idx1 = Array.FindIndex(array, IsEven);

        int idx2 = Array.FindIndex(array, bool (int n) => { return n % 2 == 0; } );
		
    }
}
