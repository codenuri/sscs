// #1. reference type �� �׻� null �� �ɼ� �ֽ��ϴ�.
string s1 = "hello";
string s2 = null;

// #2. null �� ����ϴ� ���� �����մϴ�(���� �߻�)
var ret1 = s1.Length; // 5
var ret2 = s2.Length; // ����


// #3. value type �� null �� ������� ����ڰ� �����Ҽ� �ֽ��ϴ�.
int  n1 = 10;
int? n2 = null;


// #4. ���α׷����� ���̸� �ٷ�� �ȴٰ� ������ ������
// => int �� �ϴ� ���� �����ұ�� ? int? �� �����ұ�� ?
? age = 10;


