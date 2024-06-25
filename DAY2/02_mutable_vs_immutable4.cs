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

