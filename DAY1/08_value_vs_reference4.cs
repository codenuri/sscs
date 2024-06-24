using static System.Console;

// 29 page ������
// value_type     : struct, enum - int, double ���� ǥ�� Ÿ��
// reference type : class, interface, delegate - string �迭

// �Ʒ� �ڵ��� �޸� �׸��� 29 page ���� �׸��Դϴ�.

// #1. int �� value type
int n1 = 10;
int n2 = n1;

n1 = 20;

WriteLine($"{n1} {n2}");	// 20  10	


// #2. array �� reference type
int[] x1 = {1, 2, 3};
int[] x2 = x1;

x1[0] = 20;
WriteLine($"{x1[0]} {x2[0]}");	// 20 20


// #3. string �� reference type �Դϴ�.
string s1 = "AB";
string s2 = s1;

s2 = "XY"; // new string("XY")

WriteLine($"{s1} {s2}");  // "AB", "XY"
            // ������ ���� 30 page ����!