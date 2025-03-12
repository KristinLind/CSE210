using System;

class Program
{
    static void Main()
    {
        // Create job objects
        Job job1 = new Job("Software Enginerr", "Microsoft", 2019, 2011);
        Job job2 = new Job("Manager", "Apple", 2022, 2023);

        // Create Resume object
        Resume myResume = new Resume("Allison Rose");

        //Add jobs to the resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Display the resume
        myResume.DisplayResume();
    }

}
