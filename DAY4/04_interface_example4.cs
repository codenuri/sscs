using static System.Console;


class Label : IComparable
{
    private string title;

    public Label(string s) => title = s;

    public int CompareTo(object? obj)
    {
        Label? other = obj as Label;

        if (other == null)
            return 1;

        return title.CompareTo(other.title);
    }
}

class Program
{
    public static void Main()
    {
        Label d1 = new Label("GOOD");
        Label d2 = new Label("BAD");

        int ret = d1.CompareTo(d2);


        Label d3 = (Label)d1.Clone(); // Clone 만드세요
    }


}

