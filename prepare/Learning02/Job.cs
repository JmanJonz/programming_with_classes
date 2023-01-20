using System;
public class Job
        {
            // Attributes of Job Class
            public string _company;
            public string _jobTitle;
            public int _startYear;
            public int _endYear;

            // Methods of the Job Class
            public void Display()
            {
                Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
            }
        }