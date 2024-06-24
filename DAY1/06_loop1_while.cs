using static System.Console;

int cnt = 0;

while( cnt < 10 )
{
	Write($"{cnt}, ");
	++cnt;
}
WriteLine(); // 개행.. 


cnt = 0;
while( true )	// 무한 루프
{
	Write($"{cnt}, ");

	if ( ++cnt == 10)
		break;
}

//while( cnt ) {} // C 언어 : ok
//				  // C# 언어 : error. bool 만 가능
