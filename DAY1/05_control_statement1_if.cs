// 44 page
using static System.Console;

int score = 75;

if ( score > 70 ) 
{
	WriteLine("pass");
}
else if ( score == 70 )
//{
	WriteLine("reexam"); // 실행할 문장이 1줄이면 {} 생략가능
//}
else 
{
	WriteLine("fail");
}

// C언어와의 차이점
if ( score ) { }  // C : ok. 0이 아니면 참, 0이면 거짓
                  // C# : error. bool 타입만 조건식으로 사용가능