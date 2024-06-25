using static System.Console;

// int 와 int? 사이의 변환, 비교등.. 
int  a1 = 10; // a1 은 "int 한개"
//int? n1 = 10; // n1 은 "int 한개 + bool 한개"
int? n1 = null;


int? n2 = a1; // ok      int? 에 int 를 바로 담을수 있다.
              //int  a2 = n1; // error.  int  에 int? 를 직접 담을수는 없습니다.


// #2. int? 를 int 에 담는 방법
// int a3 = (int)n1;    // ok. 캐스팅, 단, n1 이 값이 있어야 합니다.
                        // n1 이 null 이면 예외 발생. 

// int a3 = n1.Value;  // ok. Value 속성에서 꺼내기
                        // n1 이 null 이면 예외 발생

// 값이 있으면 꺼내고, 없으면 디폴트값 반환
// n1 이 null 이라도 예외 없음.
int a3 = n1.GetValueOrDefault();
int a4 = n1.GetValueOrDefault(3);

// int 와 int? 를 직접 비교 가능합니다.
// n1 == null 이라면 항상 false 입니다.
// n1 != null 이면 a3 == n1.Value 로 비교.
if (a3 == n1) 
{
    WriteLine("same");
}
else
{
    WriteLine("not same");
}





