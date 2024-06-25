using static System.Console;

// #1. construction
// => int 변수 3개 로 "tuple" 을 생성하는 코드
int a = 1, b = 2, c = 3;

var t1 = (a, b, c); // var t1 = (1,2,3)
                    // 즉, t1 은 tuple 입니다.( ValueTuple<int,int,int>)


// #2. deconstruction
// => tuple 의 요소를 int 3개에 담은 코드.
// int x, y, z;
// (x, y, z) = t1; // (x, y, z) = (1, 2, 3)
                // 즉, x = 1, y = 2, z = 3 입니다.

// 위코드는 아래 처럼해도 됩니다.
(int x, int y, int z) = t1;




// #3. 아래 2줄의 차이점을 잘 생각해 보세요.
(int a1, int a2, int a3) t2 = (1, 2, 3);
(int b1, int b2, int b3)    = (4, 5, 6);

