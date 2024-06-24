int dayofweek = 1;

// dayofweek 가 에 따라 s1 의 문자열을 설정해 보세요
// 0 : "sun"
// 1 : "mon"
// 2 : "tue"
// 그외 : "unkown"

string s1 = "";

// #1. switch statement 사용
switch(dayofweek)
{
    case 0; s1 = "sun"; break;
    case 1; s1 = "mon"; break;
    case 2; s1 = "tue"; break;
    default; s1 = "unknown";
}

// switch expression
// => 아래 코드가 위코드와 동일한 의미 입니다.
string s2 = dayofweek switch
            {
                0 => "sun",
                1 => "mon", 
                2 => "tue",
                _ => "unknown"  // 모든 경우에 값이 있어야 한다.
                                // 따라서, 이 부분은 생략될수 없다
            };

// 앞으로 새로운 언어를 학습할때는
// => if, switch 등의 제어문이 "expression" 이 될수 있는지 확인하세요
// => 예전 언어는 "statement" 로만 사용되는데, 
// => 요즘은 대부분 "expression" 이 될수도 있습니다.
