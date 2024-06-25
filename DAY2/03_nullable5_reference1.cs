// #1. reference type 은 항상 null 이 될수 있습니다.
string s1 = "hello";
string s2 = null;

// #2. null 을 사용하는 것은 위험합니다(예외 발생)
var ret1 = s1.Length; // 5
var ret2 = s2.Length; // 예외


// #3. value type 은 null 을 허용할지 사용자가 선택할수 있습니다.
int  n1 = 10;
int? n2 = null;


// #4. 프로그램에서 나이를 다루게 된다고 생각해 보세요
// => int 로 하는 것이 안전할까요 ? int? 가 안전할까요 ?
? age = 10;


