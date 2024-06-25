string s1 = "hello";

// #1. 기반 클래스 타입으로 파생 클래스 객체를 가리킬수 있습니다.
// => upcasting, 내일 자세히 
object o1 = s1;


// #2. object o1 가리키던 곳을 string 에 담을 때는
// 캐스팅 필요
//string s2 = o1; // error
string s2 = (string)o1; // ok




int n1 = o1;
int n1 = (int)o1; 	

