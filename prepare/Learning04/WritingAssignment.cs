// Import
using System;

public class WritingAssignment : Assignment
{
    // Member Variables
    private string _title;

    // Constructor Methods
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // Functionality Methods
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}
