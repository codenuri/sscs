using static System.Console;

// #1. Tuple vs ValueTuple
// Tuple      : reference type, immutable
// ValueTuple : value type,     mutable

Tuple<int, int, int> t1 = new Tuple<int, int, int>(1, 2, 3);



// #2. ValueTuple 생성
// => 핵심 : () 가 ValueTuple 을 의미 합니다
ValueTuple<int, int, int> vt1 = new ValueTuple<int, int, int>(1, 2, 3);
ValueTuple<int, int, int> vt2 = ValueTuple.Create(1, 2, 3);
ValueTuple<int, int, int> vt3 = (1, 2, 3);
(int, int, int) vt4 = (1, 2, 3);
var vt5 = (1, 2, 3);


// #3. 주의. var 의 타입 추론
var a = (1);		// "int a = 1" 즉, a 는 int
var b = (1, 2);		// "(int, int) b = (1,2)" 즉, b는 ValueTuple


// #4. 요소 접근
var vt6 = (1, 2, 3);
vt6.Item1 = 10;            // ok. mutable!!!
WriteLine($"{vt6.Item1}"); // 10



// #5. Named Member
(int, int, int)       vt7 = (1,2,3); // unnamed tuple
                                     // 요소 접근시 "Item1, Item2..." 사용

(int one, int two, int three) vt8 = (1, 2, 3); // named tuple
var vt9 = (one:1, two:2, three:3);             // named tuple



WriteLine($"{vt7.Item1}");  // 1
WriteLine($"{vt8.Item1}");  // 1
WriteLine($"{vt8.one}");    // 1
WriteLine($"{vt9.Item1}");  // 1
WriteLine($"{vt9.one}");    // 1