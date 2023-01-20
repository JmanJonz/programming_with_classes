using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display2()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job jobData in _jobs)
        {
            jobData.Display();
        }
    }
}