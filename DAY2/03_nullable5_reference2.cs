// 프로그램에서 "name" 은 항상 유효한 값을 가져야 한다.
// => 프로그램의 어디에서도 "name" 을 null 을 가져서는 안된다.
string name = "kim";


name = null; // 위 조건이라면 이 코드는 에러가 나오는것이 좋습니다.
             // 그런데, reference type 은 null 이 될수 있으므로
             // 에러가 아닙니다.
             // 

// C# 8.0 까지 : reference type 은 모두 null 이 될수 있다.
// C# 9.0 부터 : nullable reference 문법 추가
//               null 이 될수 없는 reference 와
//               null 이 될수 있는 reference 로 나누게 됩니다.
   

   