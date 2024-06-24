using static System.Console;

// 초기화되지 않은 변수의 특징
int n;          // 초기화 되지 않은 변수
int a = 0;

a = n;	// error. 초기화 되지 않은 n 을 읽을수 없다.
n = a;  // ok.   쓰기는 가능

WriteLine(n); // n 이 초기화 안되었으면 error
              // 위줄의 "n = a" 가 없다면 error.  	

a = n; // ok. n 은 이제 초기화 되었으므로
