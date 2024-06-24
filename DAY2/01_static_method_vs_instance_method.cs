// github.com/codenuri/sscs   - DAY2.zip
//----------------------------------------------------
int n = 10; // int : 타입
            // n   : 변수(객체)

// instance method : "객체이름.메소드이름" 으로 호출
//                   객체가 가진 데이타와 관련된 일을 하는 메소드

// static   method : "타입이름.메소드이름" 으로 호출
//                   특정 객체가 아닌 "타입 자체에 관련된 기능수행"

int n1 = 10;
int n2 = 20;

string s1 = n1.ToString();  // ToString() 은 instance method
                            // n1 이 가진 10 이라는 데이타를
                            // 문자열로 변경
string s2 = n2.ToString();


string s = "10";
int ret1 = int.Parse(s);    // Parse() 는 static method
                            // "int" 라는 타입에 관련된 기능수행
                            // s 문자열을 int 타입의 값으로 변경

int ret2 = Convert.ToInt32(s); // 위 코드와 동일한 기능
