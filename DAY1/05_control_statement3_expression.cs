// statement  : 실행의 기본 단위, ; 으로 끝나는 한줄
// expression : 한개의 값을 만드는 코드 집합
//              => 한개의 값을 만들기 때문에
//                 변수 초기화에 사용가능합니다.
using System;

int n = 1;


(n + 2) * 3;


int a = 1 + 2 + 3;

int b = (n + 2) * 3;

n = 3;

Console.WriteLine($"{n = 5}");

// rust 언어는 if 가 2개 입니다.
// if statement 
// if expression

// int score = 3;
// 그래서 rust 는 if 문을 아래 처럼 사용할수 있습니다.
// => 단, 이경우는 else 생략이 안됩니다.
//string s = if ( score > 70 ) "pass" else "fail";

// C# : if 는 expression 이 될수 없습니다.
//      단, switch 가 expression 이 될수 있습니다.