string s1 = "hello";

// #1. ��� Ŭ���� Ÿ������ �Ļ� Ŭ���� ��ü�� ����ų�� �ֽ��ϴ�.
// => upcasting, ���� �ڼ��� 
object o1 = s1;


// #2. object o1 ����Ű�� ���� string �� ���� ����
// ĳ���� �ʿ�
//string s2 = o1; // error
string s2 = (string)o1; // ok




int n1 = o1;
int n1 = (int)o1; 	

