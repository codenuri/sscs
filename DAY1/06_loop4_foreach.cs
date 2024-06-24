using static System.Console;

int[] x = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};


// for : 반복 횟수를 지정해야 합니다.
for( int i = 0; i < 10; i++)
{

}

// 핵심 : foreach 구문
foreach (int e in x) // x의 모든 요소를 차례대로 e 에 담기
{                    // x의 위치에는 열거 가능한(enumerable) 한 모든 객체가
                    // 올수 있습니다.
    WriteLine($"{e}, ");
}
WriteLine();

int k = 0;

foreach (int e in k) // k 는 enumerable 하지 않습니다. error 메세지 읽어보세요
{

}
