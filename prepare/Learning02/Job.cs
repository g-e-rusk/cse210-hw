// Code template for the category of things known as Job.  The reponsibility of  a Job
// id=s to hold and display company, job title, start year and end year.
using System;
public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
