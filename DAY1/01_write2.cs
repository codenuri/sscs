// 12 page
// System  : namespace 이름
// Console : 클래스 이름.
// WriteLine : static 멤버 함수(메소드)이름

using System;
using static System.Console; // 클래스 이름없이 static 메소드 호출가능

System.Console.WriteLine("Hello"); // 정확한 표기법

Console.WriteLine("Hello"); // using System 이 있는 경우
                            // 단, C#9.0 부터 자동으로 추가됨

WriteLine("Hello"); // using static System.Console가 있는 경우