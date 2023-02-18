// Imports
using System;

public class MathAssignment : Assignment
{
    // Member Variables
    private string _textbookSection;
    private string _problems;

    // Constructor Methods
    public MathAssignment(string studentName, string topic, string textbook, string problems) : base(studentName, topic)
    {
        _textbookSection = textbook;
        _problems = problems;
    }

    // Functionality Methods
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }

}

