using static System.Console;

// 객체지향 언어의 오류 처리 방법
// #1. 메소드가 실패하면 "예외"를 던집니다.


// 실패의 다양한 원인을 담은 클래스를 설계 합니다.
class DBBackupFailException
{
    // 이안에 왜 실패 했는지의 정확한 정보를 전달하기 위한
    // 다양한 멤버를 추가하세요
}

class DB
{
    public void Backup()
    {
        if ( 1 ) // 실패라고 가정
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

        bool ret = db.Backup();

        // if ( ret == false)  {  }

        db.Remove();
    }
}


