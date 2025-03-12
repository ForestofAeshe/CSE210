using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 1999;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Customer Service Agent";
        job2._company = "Apple";
        job2._startYear = 2020;
        job2._endYear = 2025;

        // Console.WriteLine(job1.Display());
        job1.DisplayJob();
        job2.DisplayJob();

        Resume myResume = new Resume();
        Console.WriteLine("What is your first name? ");
        myResume._fName = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        myResume._lName = Console.ReadLine();

        myResume._jobList.Add(job1);
        myResume._jobList.Add(job2);
        myResume._fullName = ($"{myResume._fName} {myResume._lName}");
        myResume.Display();

    }
}