string s1 = "hello";

// #1. ��� Ŭ���� Ÿ������ �Ļ� Ŭ���� ��ü�� ����ų�� �ֽ��ϴ�.
// => upcasting, ���� �ڼ��� 
object o1 = s1;


// #2. object o1 ����Ű�� ���� string �� ���� ����
// ĳ���� �ʿ�
//string s2 = o1; // error
string s2 = (string)o1; // ok


// #3. 

int n1 = o1;        // compile error
int n1 = (int)o1; 	// o1�� ����Ű�� ���� int �ƴ�. 
                    // runtime error(���� �߻�)

// #3. is ������
if ( o1 is int )
{
    int n1 = (int)o1;
}

if (o1 is int n2)
{
    // n2 ���
}

// #4. as ������ ���
// => nullable Ÿ������ ĳ���ø� ����. 
int  n3 = (int)o1;    // o1�� ����Ű�� ���� int �ƴϸ� ����
int? n4 = o1 as int?; // o1�� ����Ű�� ���� int �ƴϸ� null��ȯ
int  n5 = o1 as int;  // error. 

int  n6 = (o1 as int?) ?? 0;



