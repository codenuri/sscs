using static System.Console;

// 29 page 오른쪽
// value_type     : struct, enum - int, double 등의 표준 타입
// reference type : class, interface, delegate - string 배열

// 아래 코드의 메모리 그림이 29 page 왼쪽 그림입니다.

// #1. int 는 value type
int n1 = 10;
int n2 = n1;

n1 = 20;

WriteLine($"{n1} {n2}");	// 20  10	


// #2. array 는 reference type
int[] x1 = {1, 2, 3};
int[] x2 = x1;

x1[0] = 20;
WriteLine($"{x1[0]} {x2[0]}");	// 20 20


// #3. string 은 reference type 입니다.
string s1 = "AB";
string s2 = s1;

s2 = "XY"; // new string("XY")

WriteLine($"{s1} {s2}");  // "AB", "XY"
            // 이유는 교재 30 page 참고!