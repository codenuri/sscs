int n1;		// 초기화 안됨.

// 변수의 초기값을 지정하는 방법.
// => 아래 코드는 모두 "완전히 동일" 합니다.
int n2 = 0;
int n3 = new int();
int n4 = default(int);  // 21 page 표 참고
                        // int 의 디폴트 값(0)으로 초기화!
int n5 = default;       // 좌변 타입(int)의 디폴트 값

// var n6 = default;       // error
var n7 = default(int);  // ok

// LINQPad 실행하세요


// #2. default 같은 방식은 "generic" 에서 유용하게 활용됩니다.
void goo<T>(T n)
{
//  T a = 초기값;  // 초기값 자리에 "default" 를 사용하게 됩니다.
}


// #3. C# 에서 모든 변수(객체)의 생성은 "new" 로 해야 합니다.
// => 단, int, double, string 등의 표준 타입은
//    "편의(단축) 표기법" 을 제공합니다.

int a1 = new int();
int a2 = 0; // 위와 완벽히 동일

// int 타입의 경우 위 2줄은 완전히 동일합니다.

// 하지만 string 인 아래 2줄은 차이가 있습니다.
string s1 = new string("ABC");
string s2 = "ABC"; // 위와 약간의 차이가 있습니다.