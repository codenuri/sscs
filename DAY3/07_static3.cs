using static System.Console;

// 프로그램에서 날짜를 많이 다루게 됩니다.

class Date
{
    // 복습할때 set 에서 유효성 검사 추가해 보세요
    public int Year  { get; set; } = 0;
    public int Month { get; set; } = 0;
    public int Day   { get; set; } = 0;

    // 월별 날짜수를 알아야, 다양한 날짜 관련 연산을 수행할수 있습니다.
    // => 아래 data 는 날짜 객체당 한개일 필요 없습니다.
    // => 모든 날짜 객체가 한개를 같이 사용하면 됩니다
    // => 아래 같은 데이타를 static 으로 관리하게 됩니다.
    private static int[] days = { 31, 28, 30, 31, 30, 31, 30, 31, 30, 31, 30, 31 };




    public Date(int y, int m, int d)
        => (Year, Month, Day) = (y, m, d);

    public Data AfterDays(int ds)
    {
        // 1000일 뒤 날짜 반환
        // => 잘못된 구현 입니다. 복습할때 제대로 구현해 보세요.
        return new Date(Year, Month, Day + ds);
    }
}

class Program
{
    public static void Main()
    {
        Date d1 = new Date(2024, 6, 24);
        Date d2 = new Date(2024, 7, 1);

        Date dest = d1.AfterDays(1000);
    }
}