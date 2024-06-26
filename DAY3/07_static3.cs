using static System.Console;

// 프로그램에서 날짜를 많이 다루게 됩니다.

class Date
{
    // 복습할때 유효성 검사 추가해 보세요
    public int Year { get; set; } = 0;
    public int Month { get; set; } = 0;
    public int Day { get; set; } = 0;

    public Date(int y, int m, int d)
        => (Year, Month, Day) = (y, m, d);
}

class Program
{
    public static void Main()
    {
        Date d = new Date(2024, 6, 24);
    }
}