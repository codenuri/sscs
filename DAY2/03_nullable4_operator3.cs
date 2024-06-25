string s1 = "hello";

// #1. 기반 클래스 타입으로 파생 클래스 객체를 가리킬수 있습니다.
// => upcasting, 내일 자세히 
object o1 = s1;


// #2. object o1 가리키던 곳을 string 에 담을 때는
// 캐스팅 필요
//string s2 = o1; // error
string s2 = (string)o1; // ok


// #3. 

int n1 = o1;        // compile error
int n1 = (int)o1; 	// o1이 가리키는 것은 int 아님. 
                    // runtime error(예외 발생)

// #3. is 연산자
if ( o1 is int )
{
    int n1 = (int)o1;
}

if (o1 is int n2)
{
    // n2 사용
}

// #4. as 연산자 사용
// => nullable 타입으로 캐스팅만 가능. 
int  n3 = (int)o1;    // o1이 가리키는 곳인 int 아니면 예외
int? n4 = o1 as int?; // o1이 가리키는 곳인 int 아니면 null반환
int  n5 = o1 as int;  // error. 

int  n6 = (o1 as int?) ?? 0;



