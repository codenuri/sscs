// 36 page ~

// #1. reference type 은 null 이 될수 있습니다.
// => 객체(값)없음을 나타낼수 있습니다.
string s1 = "hello";
string s2 = null;	// ok	

// #2. value type 은 null 이 될수 없습니다.
// => 값 없음을 표현할수 없습니다.
int n1 = 0;
// int n2 = null;	// error

int some_work(int arg)
{
    // 반환 값으로 실패를 알리고 싶다
    return 0;   // 0은 "값없음"을 나타내지는 않습니다.
                // 단지, 약속으로 0, -1 등을 "실패(값없음)"으로 약속한것일뿐
}

// #3. Nullable<T> 를 사용하면 value type에 null 로 초기화 가능합니다.
// => T 는 반드시 value type 이어야 합니다.

Nullable<int> n2 = null;
  



