//#nullable disable // nullable reference 문법을 사용하지말라
#nullable enable    // nullable reference 문법을 사용해달라.

string name = "kim";

Console.WriteLine(name);

name = null; // C# 8.0 까지 에러아님. 경고도 없음
             // C# 9.0 부터. 이코드는 null 이 될수 없는 코드
             // 단, 에러는 아니고 경고로 처리(과거와의 호환성)

string  s1 = null; // 경고, null 을 사용할수 없는 reference
string? s2 = null; // ok. null 이 될수 있는 reference
                   // 단, 이코드는 C#8.0 까지는 에러

