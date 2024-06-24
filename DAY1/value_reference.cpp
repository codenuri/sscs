// value_reference.cpp

// C++ 코드입니다. C++을 모르시는 분들도, 개념만 잘 알아두세요
// => 교재 27page 참고
struct Point
{
	int x, y;
};

int main()
{
	Point pt;	// stack 에 객체 생성
			
	Point* p1 = new Point;	// heap 에 객체 생성
}