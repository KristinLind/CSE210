using System;

public class Job
{
    // Member variables (fields)
    private string _jobTitle;
    private string _company;
    private int _startYear;
    private int _endYear;

    // Constructor to initialize the Job object
    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        _jobTitle = jobTitle;
        _company = company;
        _startYear = startYear;
        _endYear = endYear;
    }

    // Display method to show job details in the required format
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

    // Getters and setters if needed (optional)
    public string Jobtitle { get => _jobTitle; set => _jobTitle = value; }
    public string Company { get => _company; set => _company = value; }
    public int StartYear { get => _startYear; set => _startYear = value; }
    public int EndYear { get => _endYear; set => _endYear = value; }
}