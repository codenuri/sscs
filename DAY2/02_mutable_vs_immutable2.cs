using System;
using static System.Console;

string s1 = "AB";
string s2 = s1;

WriteLine($"{s2[0]}"); // 'A'

// object 클래스의 static method 인
// ReferenceEqual() 을 사용하면 
// 2개의 레퍼런스 변수가 같은 객체를 가리키는지 조사가능합니다.

WriteLine($"{object.ReferenceEquals(s1, s2)}"); // true

s2 = "XY"; // new string("XY")

WriteLine($"{object.ReferenceEquals(s1, s2)}"); // false

