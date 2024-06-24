int dayofweek = 1;

// dayofweek �� �� ���� s1 �� ���ڿ��� ������ ������
// 0 : "sun"
// 1 : "mon"
// 2 : "tue"
// �׿� : "unkown"

string s1 = "";

// #1. switch statement ���
switch(dayofweek)
{
    case 0; s1 = "sun"; break;
    case 1; s1 = "mon"; break;
    case 2; s1 = "tue"; break;
    default; s1 = "unknown";
}

// switch expression
// => �Ʒ� �ڵ尡 ���ڵ�� ������ �ǹ� �Դϴ�.
string s2 = dayofweek switch
            {
                0 => "sun",
                1 => "mon", 
                2 => "tue",
                _ => "unknown"  // ��� ��쿡 ���� �־�� �Ѵ�.
                                // ����, �� �κ��� �����ɼ� ����
            };

// ������ ���ο� �� �н��Ҷ���
// => if, switch ���� ����� "expression" �� �ɼ� �ִ��� Ȯ���ϼ���
// => ���� ���� "statement" �θ� ���Ǵµ�, 
// => ������ ��κ� "expression" �� �ɼ��� �ֽ��ϴ�.
