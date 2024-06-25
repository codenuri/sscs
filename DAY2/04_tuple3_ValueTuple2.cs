using static System.Console;

// #1. construction
// => int ���� 3�� �� "tuple" �� �����ϴ� �ڵ�
int a = 1, b = 2, c = 3;

var t1 = (a, b, c); // var t1 = (1,2,3)
                    // ��, t1 �� tuple �Դϴ�.( ValueTuple<int,int,int>)


// #2. deconstruction
// => tuple �� ��Ҹ� int 3���� ���� �ڵ�.
// int x, y, z;
// (x, y, z) = t1; // (x, y, z) = (1, 2, 3)
                // ��, x = 1, y = 2, z = 3 �Դϴ�.

// ���ڵ�� �Ʒ� ó���ص� �˴ϴ�.
(int x, int y, int z) = t1;




// #3. �Ʒ� 2���� �������� �� ������ ������.
(int a1, int a2, int a3) t2 = (1, 2, 3);    // t2��� tuple �� �����Ѱ�
                                            // �� ��Ҵ� a1, a2, a3�̸����
                                            // named tuple
                                            // "(int a1, int a2, int a3)" �� Ÿ��

(int b1, int b2, int b3)    = (4, 5, 6);    // tuple  �� ������ �ƴ�
                                            // deconstruction �ڵ�
                                            // (4,5,6) �̶�� tuple �� ����Ҹ�
                                            // int 3�� ������ ������

// ������ ������ ã������..
int a1 = 10; // ok.    24 ��° ���� a1 �� ������ ������ �ƴ� tuple ����� �̸�
int b1 = 10; // error. b1 �̶�� �̸��� ������ 29��° �ٿ��� ������.

// deconstruction ���� ���� ���� ����� _ �� �ϸ� �˴ϴ�.
var t5 = (1, 2, 3);

//(int c1, int c2) = t5;    // error
(int c1, int c2, _) = t5; // ok





