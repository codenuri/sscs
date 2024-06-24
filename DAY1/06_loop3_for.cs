using static System.Console;

int[] x = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

for( int i = 0; i < 10; i++ )
{
	WriteLine($"{i} : {x[i]}");
}

int j = 0;

for( ; ; )	// 무한루프
{
	WriteLine($"{j} : {x[j]}");

	if ( ++j == 10 )
		break;
}

int n = 3;

//int a = ++n; // n 을 증가하고 4 를 a에 넣기
//int a = n++; // n 을 증가하고 n 의 이전값 3 를 a에 넣기
