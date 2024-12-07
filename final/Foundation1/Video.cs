using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length; 
    private List<Comment> _commentsList = new List<Comment>();

    public Video(string title, string author, int length)
    {   
        _title = title;
        _author = author;
        _length = length;

    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetLength(int length)
    {
        _length = length;
    }

    public int GetLength()
    {
        return _length;
    }

    public void SetCommentsList(List<Comment> commentsList)
    {
        _commentsList = commentsList;
    }

    public List<Comment> GetCommentsList()
    {
        return _commentsList;
    }

    public void DisplayVideoComments()
    {
        foreach (Comment comment in _commentsList)
        {
            comment.DisplayComment(); // Put the DisplayComment() here
        }
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"{new string('-', 40)}\nVideo Title: '{_title}'\nAuthor: @{_author}\nVideo Length: {_length} minutes\n {new string('-', 40)}");

    }

    public void AddComment(Comment comment)
    {
        _commentsList.Add(comment); // Later, in program class, create 4 Comment instances and use Addcomment() to add them into 1 Video instance.
    }

}