// 30 page ~
// mutable   : 객체의 속성을 변경할 수 있는 것 
// immutable : 객체의 속성을 변경할 수 없는 것 

// C# 에서
// 배열은 "mutable" 입니다.
// string "immutable" 입니다.

int[] x = { 1, 2, 3 };
x[0] = 10; // ok


string s = "ABC";
s[0] = 'X'; // error

s = "XY"; // 왜 에러가 아닌가요 ?
          // 기존 객체를 변경한 것이 아니라
          // "새로운 객체를 만들고 s가 새로운 객체를 가리키는 것"
          // s = new string("XY")

