using static System.Console;

// int �� int? ������ ��ȯ, �񱳵�.. 
int  a1 = 10; // a1 �� "int �Ѱ�"
//int? n1 = 10; // n1 �� "int �Ѱ� + bool �Ѱ�"
int? n1 = null;


int? n2 = a1; // ok      int? �� int �� �ٷ� ������ �ִ�.
              //int  a2 = n1; // error.  int  �� int? �� ���� �������� �����ϴ�.


// #2. int? �� int �� ��� ���
// int a3 = (int)n1;    // ok. ĳ����, ��, n1 �� ���� �־�� �մϴ�.
                        // n1 �� null �̸� ���� �߻�. 

// int a3 = n1.Value;  // ok. Value �Ӽ����� ������
                        // n1 �� null �̸� ���� �߻�

// ���� ������ ������, ������ ����Ʈ�� ��ȯ
// n1 �� null �̶� ���� ����.
int a3 = n1.GetValueOrDefault();
int a4 = n1.GetValueOrDefault(3);

// int �� int? �� ���� �� �����մϴ�.
// n1 == null �̶�� �׻� false �Դϴ�.
// n1 != null �̸� a3 == n1.Value �� ��.
if (a3 == n1) 
{
    WriteLine("same");
}
else
{
    WriteLine("not same");
}





