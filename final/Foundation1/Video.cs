using System.Runtime.CompilerServices;
using System.Transactions;

class Video 
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    int numComments = 0;
    public int NumOfComments()
    {
        foreach(Comment comment in _comments)
        {
            numComments += 1;
        }
        
        return numComments;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title} By {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {NumOfComments()}");

        foreach(Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}