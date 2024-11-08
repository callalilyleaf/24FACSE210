using System;

class WritingAssignment : Assignment
{
    private string _title;

    public string GetWritingInformation()
    {
        return $"Here's the writing information: {_title}."
    }
}