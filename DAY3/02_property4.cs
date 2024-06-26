using static System.Console;

string s = "ABCD";

int[] arr = { 1, 2, 3, 4 };

// C# 은 객체의 다양한 정보를 얻고 싶을때
// => 메소드가 아닌 "속성"을 사용하는 경우가 많습니다
WriteLine(s.Length);  // s.GetLength() 같은 메소드가 아닙니다.

// 속성이 아닌 메소드를 사용하는 경우는
// 1. 단순히 정보를 얻는 것이 아닌, 어떤 연산을 하거나
// 2. 정보를 얻을때도 인자가 필요한 경우 입니다.
WriteLine( arr.Length);
WriteLine(arr.GetLength(0));


