// 33 page ~ 
using static System.Console;

// �迭 : "���� Ÿ��"�� ��ü�� ������ �����մϴ�.
//        "homogeneouse container"
int[] array = {1, 2, 3};


// Ʃ�� : "�ٸ� Ÿ��"�� ��ü�� ������ �����Ҷ� ����մϴ�.

// C# tuple - 33page
// Tuple      : .net 4.0   reference type, immutable
// ValueTuple : .net 4.7   value type,     mutable  <== ����.

Tuple<int, double, string> t1 = 
			new Tuple<int, double, string>(1, 3.4, "AA");

WriteLine($"{t1.Item1}"); // 1
WriteLine($"{t1.Item2}"); // 3.4
WriteLine($"{t1.Item3}"); // "AA"


