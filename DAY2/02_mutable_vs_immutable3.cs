using System;
using static System.Console;

// 아래 2줄은 완전히 동일합니다.
int n1 = 0;
int n2 = new int();

// 아래 4줄은 차이가 있습니다.

// #1. new 를 사용하지 않은 경우
// => 아래 코드는 "BBB" 를 가진 문자열 객체를 한개만 만들게 되고
// => s1, s2 가 공유 하게 됩니다.
string s1 = "BBB"; // new string("BBB")
string s2 = "BBB";

WriteLine($"{object.ReferenceEquals(s1, s2)}");

// #2. 아래 처럼 "new" 로 문자열을 만들면
//     공유하지 않고, 다른 객체가 생성됩니다.
string s3 = new string("AAA");
string s4 = new string("AAA");
WriteLine($"{object.ReferenceEquals(s3, s4)}");


