using static System.Console;

int[] x = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};


// for : �ݺ� Ƚ���� �����ؾ� �մϴ�.
for( int i = 0; i < 10; i++)
{

}

// �ٽ� : foreach ����
foreach (int e in x) // x�� ��� ��Ҹ� ���ʴ�� e �� ���
{                    // x�� ��ġ���� ���� ������(enumerable) �� ��� ��ü��
                    // �ü� �ֽ��ϴ�.
    WriteLine($"{e}, ");
}
WriteLine();

int k = 0;

foreach (int e in k) // k �� enumerable ���� �ʽ��ϴ�. error �޼��� �о����
{

}
