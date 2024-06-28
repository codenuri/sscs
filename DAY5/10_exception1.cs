using static System.Console;

// #1. 대부분 메소드는 주어진 작업을 수행하다가 실패 할수도 있다

// 방법 #1. 반환값으로 실패 전달
// => 호출자가 "함수의 실패" 를 무시할수도 있습니다.
// => 함수의 심각한 오류 발생을 무시하는 경우, 더욱 큰 문제가 될수있습니다.

class DB
{
    public bool Backup() 
    {
        return false;
    }

    public void Remove() { WriteLine("Remove DB");  }
}
class Program
{
    public static void Main()
    {
        DB db = new DB();

        bool ret = db.Backup();

        // if ( ret == false)  {  }

        db.Remove();
    }
}


