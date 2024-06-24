// C# 은 함수 오버로딩 문법을 지원합니다
// => 인자의 타입이나 갯수가 다르면 동일 이름의 함수를
//    여러개 만들수 있다는 것

int Square(int a)       { return a * a; }
double Square(double a) { return a * a; }


int n = Square(3);