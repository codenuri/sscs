// 23 page ~
using System;
using System.Security.Cryptography.X509Certificates;

// C/C++/Java ���
// => int, double ���� �����ü�� �ν��ϴ� Ÿ���Դϴ�.
// => struct, class �� ���� Ÿ���� ������� �ֽ��ϴ�
/*
struct Point
{
    int x, y;
};
*/
//===================================
// C# : ��� Ÿ���� C# �� �������� �ʰ�,
//      CLR �� ���� ���� �˴ϴ�.(CTS)
//      ��� Ÿ���� struct �ƴϸ� class�� ����Ǿ����ϴ�.

// CLR ���� "32bit ����" �� Int32 ��� struct �� ���� �Ǿ����ϴ�.
/*
struct Int32
{
    // ��� ����Ÿ��
    // �پ��� ��� �Լ�(�޼ҵ�)..
}
*/

// C#�� int �� CLR ���� ������ "Int32" ����ü�� ���� alias �ϻ� �Դϴ�.

// ���� �Ʒ� 3���� ������ �����մϴ�.
int          n1 = 0;
System.Int32 n2 = 0;
Int32        n3 = 0;


double d1 = 0;
System.Double d2 = 0;
Double d3 = 0;


string s1 = "A";
System.String s2 = "A";
string s3 = "A";

// 23 page

