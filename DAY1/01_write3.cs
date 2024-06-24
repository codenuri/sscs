using static System.Console;

int a = 10;
int b = 20;

// 변수의 값을 출력하는 방법.

// 방법 #1. 변수 한개만 출력 할때는 아래 처럼
WriteLine(a);

// 방법 #2. 서식에 맞춰 출력
WriteLine("a = {0}, b = {1}", a, b);

// $ 문자열을 사용하면 아래 처럼 {} 안에 변수명을 직접 넣을수 있습니다.
WriteLine($"a = {a}, b = {b}");


