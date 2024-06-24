// 23 page ~
using System;
using System.Security.Cryptography.X509Certificates;

// C/C++/Java 언어
// => int, double 등은 언어자체가 인식하는 타입입니다.
// => struct, class 로 직접 타입을 만들수도 있습니다
/*
struct Point
{
    int x, y;
};
*/
//===================================
// C# : 모든 타입은 C# 언어가 정의하지 않고,
//      CLR 에 의해 정의 됩니다.(CTS)
//      모든 타입은 struct 아니면 class로 설계되었습니다.

// CLR 에서 "32bit 정수" 는 Int32 라는 struct 로 정의 되었습니다.
/*
struct Int32
{
    // 멤버 데이타와
    // 다양한 멤버 함수(메소드)..
}
*/

// C#의 int 는 CLR 에서 정의한 "Int32" 구조체에 대한 alias 일뿐 입니다.

// 따라서 아래 3줄은 완전히 동일합니다.
int          n1 = 0;
System.Int32 n2 = 0;
Int32        n3 = 0;


double d1 = 0;
System.Double d2 = 0;
Double d3 = 0;


string s1 = "A";
System.String s2 = "A";
string s3 = "A";

// 23 page

