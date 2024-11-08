using System;

// Q: Does the child access the parent class or copy the parent class?

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public string GetHomeworkList()
    {
        return $"{_textbookSection} and {_problems} are finished. ";
    }

}

