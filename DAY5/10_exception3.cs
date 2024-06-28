using static System.Console;

// 객체지향 언어의 오류 처리 방법
// #1. 메소드가 실패하면 "예외"를 던집니다.



class DBBackupFailException : Exception
{
}

class DB
{
    public void Backup()
    {
        if (true) 
        {
            throw new DBBackupFailException();
        }
    }

    public void Remove() { WriteLine("Remove DB"); }
}
class Program
{
    public static void Main()
    {
        DB db = new DB();

        // #1. 예외 가능성이 있는 메소드를 호출할때는 "try" 안에서 합니다.

        try
        {
            db.Backup();
        }
        catch (DBBackupFailException e)
        {
            WriteLine("DBBackup 실패");

            // 예외의 원인을 해결할수 없다면 여기서 프로그램을 종료.
            // 여기서 종료하지 않으면 계속 실행가능
        }
        catch (Exception e) // 위에서 잡지 못한 모든 예외를 잡을때사용
        {
            WriteLine("알수 없는 예외");
        }





        db.Remove();
    }
}


