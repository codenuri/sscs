class Example1
{
    private int data1 = 0;
    private int data2 = 0;
    private int data3 = 0;
    private int data4 = 0;
    private int data5 = 0;

    // property �� ����� ���ô�.

    // #1. �⺻ �ڵ�.
    public int Data1
    {
        get { return data1; }
        set { data1 = value; }
    }

    // #2. expression bodied
    public int Data2
    {
        get => data2;
        set => data2 = value; 
    }

    // #3. get only
    // var ret = e.Data3; // ok
    // e.Data3 = 10;      // error
    public int Data3
    {
        get => data3;
    }

    // #4. set only
    // var ret = e.Data4; // error
    // e.Data4 = 10;      // ok
    public int Data4
    {
        set => data4 = value;
    }

    // #5. private set
    // => �ܺο����� set �� �ȵ�.
    // => ���ο����� ����
    public int Data5
    {
        get => data5;
        private set => data5 = value;
    }

    public Example1()
    {
        data5 = 0; // �ʵ带 ���� �����ϴ� �ڵ�

        Data5 = 0; // �Ӽ��� ���ؼ� �����ϴ� �ڵ�
                    // ��ȿ�� �˻� ������ �ִٸ� �����.
                    // private ������ �޼ҵ��̹Ƿ� ���� ����
    }
}

class Program
{
    public static void Main()
    {
        Example1 e1 = new Example();
        e1.Data5 = 10; // error. private set
    }
}
