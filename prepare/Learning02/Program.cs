using System;

class Program
{
    static void Main(string[] args)
    {
        Job job = new Job();
        job._company = "Microsoft";
        job._startYear = 1975;
        job._endYear = 1980;
        job._jobTitle = "Software Engineer";

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume resume = new Resume();
        resume._name = "Luciana Puerta";
        
        resume._jobs.Add(job);
        resume._jobs.Add(job2);

        resume.Display();
    }
}