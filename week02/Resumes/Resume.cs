using System;

public class Resume
{
    public string _fName = "";
    public string _lName = "";

    public string _fullName;

    public List<Job> _jobList = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_fullName}");
        Console.WriteLine($"Jobs:");
        
        foreach (Job i in _jobList)
        {
            i.DisplayJob();
        }
    }
}