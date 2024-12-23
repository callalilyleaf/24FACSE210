using System;

public class WritingAssignment : Assignment
{
    string _title = "";

    public WritingAssignment()
    {
        _title = "Unknown";
    }

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_studentName} - {_topic}\n{_title} by {_studentName}";
    }


}