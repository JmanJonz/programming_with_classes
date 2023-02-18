using System;

public class Assignment
{
    // Member Variables
    protected string _studentName;
    private string _topic;

    // Constructor Methods
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Functionality Methods
    public string GetSummary()
    {
        return "Name: " + _studentName + " Topic: " + _topic;
    }


}