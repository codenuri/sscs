using static System.Console;
// Sentence : 문장을 단어별로 관리/접근 할수 있는 클래스
class Sentence
{
    // 아래 필드는 아직 배열 객체는 만들지 않고, 단지 reference만 있습니다.
    private string[] words;
//  private string[] words = new string[3]; // 이렇게 해야 배열 생성한것

    public Sentence(string s) 
	{
        // s.Split() : s 문자열을 단어별로 분리해서 배열 생성
        //             
        words = s.Split();  // words = new string[] {"Dog", "is", "Animal"}
    }

    // 인덱서(indexer) : 객체를 배열처럼 사용하고 싶을때 사용
    // property 와 동일한 모양인데, 
    // "이름" 위치에 "this[]" 로 표기

//  public string Name            // property
    public string this[int index] // indexer
    {
        get =>words[index];
        set => words[index] = value;    // 구현은 property 와 동일
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
