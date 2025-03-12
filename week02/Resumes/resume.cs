using System;
using System.Collections.Generic;

public class Resume
{

    // Member variables
    private string _name;
    private List<Job> _jobs;

    // constructor to initialize the Resume object
    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }

    // Metho to add job to the resume
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Display method to show the resume details
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }

    // Getters and setters if needed 
    public string Name { get => _name; set => _name = value; }
    public List<Job> Jobs { get => _jobs; set => _jobs = value; }
}
