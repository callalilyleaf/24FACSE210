using System;

public class Comment
{
    private string _commentAuthor;
    private string _commentText;
    private string _hoursAgo;

    public Comment(string commentAuthor, string commentText, string hoursAgo)
    {
        _commentAuthor = commentAuthor;
        _commentText = commentText;
        _hoursAgo = hoursAgo;
    }
    
    public void SetCommentAuthor(string commentAuthor)
    {
        _commentAuthor = commentAuthor;
    }

    public string GetCommentAuthor()
    {
        return _commentAuthor;
    }

    public void SetCommentText(string commentText)
    {
        _commentText = commentText;
    }

    public string GetCommentText()
    {
        return _commentText;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"@{_commentAuthor} {_hoursAgo}\n{_commentText}\n");
    }
}