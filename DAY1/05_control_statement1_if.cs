// 44 page
using static System.Console;

int score = 75;

if ( score > 70 ) 
{
	WriteLine("pass");
}
else if ( score == 70 )
//{
	WriteLine("reexam"); // ������ ������ 1���̸� {} ��������
//}
else 
{
	WriteLine("fail");
}

// C������ ������
if ( score ) { }  // C : ok. 0�� �ƴϸ� ��, 0�̸� ����
                  // C# : error. bool Ÿ�Ը� ���ǽ����� ��밡��