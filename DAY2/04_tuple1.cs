// 33 page ~ 
using static System.Console;

// 배열 : "같은 타입"의 객체를 여러개 보관합니다.
//        "homogeneouse container"
int[] array = {1, 2, 3};


// 튜플 : "다른 타입"의 객체를 여러개 보관할때 사용합니다.

// C# tuple - 33page
// Tuple      : .net 4.0   reference type, immutable
// ValueTuple : .net 4.7   value type,     mutable  <== 권장.

Tuple<int, double, string> t1 = 
			new Tuple<int, double, string>(1, 3.4, "AA");

WriteLine($"{t1.Item1}"); // 1
WriteLine($"{t1.Item2}"); // 3.4
WriteLine($"{t1.Item3}"); // "AA"


