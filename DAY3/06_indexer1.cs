using static System.Console;
// Sentence : ������ �ܾ�� ����/���� �Ҽ� �ִ� Ŭ����
class Sentence
{
    // �Ʒ� �ʵ�� ���� �迭 ��ü�� ������ �ʰ�, ���� reference�� �ֽ��ϴ�.
    private string[] words;
//  private string[] words = new string[3]; // �̷��� �ؾ� �迭 �����Ѱ�

    public Sentence(string s) 
	{
        // s.Split() : s ���ڿ��� �ܾ�� �и��ؼ� �迭 ����
        //             
        words = s.Split();  // words = new string[] {"Dog", "is", "Animal"}
    }

    // �ε���(indexer) : ��ü�� �迭ó�� ����ϰ� ������ ���
    // property �� ������ ����ε�, 
    // "�̸�" ��ġ�� "this[]" �� ǥ��

//  public string Name            // property
    public string this[int index] // indexer
    {
        get =>words[index];
        set => words[index] = value;    // ������ property �� ����
    }
}

class Program
{
    public static void Main()
    {
        Sentence s = new Sentence("Dog is Animal");

        WriteLine( s[2] ); 	// Animal

        s[0] = "Cat";

//      WriteLine(s.Text);  // Cat is Animal
    }
}
