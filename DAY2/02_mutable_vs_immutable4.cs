using System;
using System.Text;
using static System.Console;

// #1. string 은 immutable 합니다.
string s = "AB";
//s[0] = 'X'; // error.

// string 의 메소드 중에서 "변경"하는 메소드는 없습니다.
string s1 = s.ToLower(); // s 가 변경되는 것이 아니라!
                         // s의 문자열 "AB" 가 소문자로된 "ab"
                         // 를 가진 새로운 객체를 반환한것

// mutable 한 string 이 필요 하면 StringBuilder 를 사용하세요
StringBuilder sb = new StringBuilder("ABCD");

sb[0] = 'X'; // ok

WriteLine(sb); // "XBCD"

// 문자열 변경에 관련된 많은 메소드가 있습니다.
sb.Append("KK");

WriteLine(sb); // "XBCDKK"

// StringBuilder 는 "new" 로만 생성가능합니다.
// => 단축 표기법 제공안됨
// StringBuilder sb1 = "ABCD"; // error

// 변경할 필요가 있을때만 StringBuilder 사용하세요
// 항상 "immutable" 이 빠르고 안전합니다. 동기화도 필요 없습니다.
// "mutable" 은 고려사항이 많습니다.


/*
// C/C++/JAVA/C#
// => 기본이 mutable, 
// => 단, string 등의 성능에 중요한 영향을 미치는 경우 
//    타입 자체를 immutable 하게 제공
int n = 0;       // n 은 mutable 합니다. 변경가능
const int c = 0; // c 는 immutable 합니다. 변경 불가능.

// RUST, haskell 등의 함수 형 언어
// => 모든 타입은 기본이 "immutable"
// => 변경 가능하려면 "mut" 사용
n: int  = 10;       // immutable 합니다. 변경 불가능.
n: mut int  = 10;   // mutable 합니다. 변경 가능.
*/