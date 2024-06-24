// 24 page ~ 

// C/C++/Java
/*
// 1. int 타입의 변수에는 "멤버함수"등의 개념이 없습니다.
int n1 = 10;
n1.foo(); // error.


// 2. struct/class 로 만들면 멤버함수, 멤버 데이타 등을 넣을수
// 있습니다.
struct Point
{
    int x, y;
    void print() { }
}

Point pt;
pt.print();
*/
// C# 이 처음 등장할때 "핵심 으로 주장한 개념"
// => 모든 것은 객체이다.


using System;

int n1 = 10;

// 핵심 : 모든 것은 객체이다.

string s1 = n1.ToString();  // n1 이 가진 값(10) 을
                            // 문자열로 반환하는 메소드

string s2 = 10.ToString();  // literal 10도 int 타입입니다.
                            // 메소드가 있습니다.

// 용어 정리
// 객체 n1과 관련된 함수
// C++ : "멤버 함수" 라고 부릅니다.
// Java, C#, Python 등 : "메소드"라고 합니다.