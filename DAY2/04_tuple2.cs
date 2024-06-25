using static System.Console;

// #1. Tuple 을 생성하는 다양한 방법
Tuple<int, int, int> t1 = new Tuple<int, int, int>(1,2,3);

Tuple<int, int, int> t2 = Tuple.Create(1, 2, 3);

// Tuple 같은 타입을 사용시에는 "var" 를 사용하는 것이 편리합니다. 
var t3 = new Tuple<int, int, int>(1,2,3);

// 결국, 아래 처럼 사용하시는 것이 제일 편리합니다.
var t4 = Tuple.Create(1, 2, 3);


// #2. Tuple 은 immutable 합니다.
//t4.Item1 = 10;    // error
int n = t4.Item1; // ok

// #3. 8개 까지만 저장 가능합니다.
//var t5 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8, 9); // error
var t5 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8); // ok

// #4. 8번째 접근 방법이 특이합니다.
WriteLine($"{t5.Item1}"); // 1
WriteLine($"{t5.Item7}"); // 7
WriteLine($"{t5.Rest}"); // (8)
WriteLine($"{t5.Rest.Item1}"); // 8

// #5. 8개이상 사용하려면 nested 구조로 사용합니다.
var t6 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10));

WriteLine($"{t6.Rest.Item1}"); // (8, 9, 10)
WriteLine($"{t6.Rest.Item1.Item1}"); // 8
WriteLine($"{t6.Rest.Item1.Item2}"); // 9