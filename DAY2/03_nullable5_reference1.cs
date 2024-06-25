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
// => 일반적으로 "나이(age)" 는 null 이 될수 없습니다.
// => 이경우 int? 로 만들면 실수로 null 을 가질수 있게 되고
//    안전하지 않은 코드가 됩니다.
// => 항상 변수는 유효한 값을 가지는 것이 안전합니다.
// => 즉, 반드시 필요하지 않다면 int? 를 사용하지 말고 int를 사용하세요

int age = 10;


